using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.DTOs.Auth;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace API.Repositories;

public class AuthManagerRepository : IAuthManagerRepository
{
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _config;
    private readonly SymmetricSecurityKey _key;
    private User? _user;
    public AuthManagerRepository(
        UserManager<User> userManager,
        IConfiguration config
    )
    {
        _userManager = userManager;
        _config = config;
        _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"]));
    }
    public async Task<bool> CheckUserExists(string email)
    {
        _user = await _userManager.FindByEmailAsync(email);
        return _user != null;
    }

    public async Task<string> GenerateToken(User user)
    {
        _user = user;
        var claims = await GetClaims();

        var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);


        var token = new JwtSecurityToken(
            issuer: _config["Token:Issuer"],
            claims: claims,
            expires: DateTime.Now.AddMonths(3),
            signingCredentials: credentials
        );

        var tokenHandler = new JwtSecurityTokenHandler();

        return tokenHandler.WriteToken(token);
    }

    public async Task<bool> ValidateUser(UserLoginDto userLoginDto)
    {
        _user = await _userManager.FindByEmailAsync(userLoginDto.Email);
        var result = await _userManager.CheckPasswordAsync(_user, userLoginDto.Password);
        return (_user != null && result);
    }

    private Task<List<Claim>> GetClaims()
    {
        var claims = new List<Claim>(){
            new Claim(ClaimTypes.Email, _user!.Email),
            new Claim(ClaimTypes.Name, $"{ _user.FirstName} {_user.LastName}"),
            new Claim(ClaimTypes.Role, _user.Role)
        };

        return Task.FromResult(claims);
    }
}