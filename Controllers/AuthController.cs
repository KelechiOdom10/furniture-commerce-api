using System.Security.Claims;
using API.DTOs.Auth;
using API.DTOs.User;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace commerceAPI.Controllers;

[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly IAuthManagerRepository _authManager;
    private readonly IMapper _mapper;

    public AuthController(
        UserManager<User> userManager,
        IMapper mapper,
        IAuthManagerRepository authManager
        )
    {
        _mapper = mapper;
        _userManager = userManager;
        _authManager = authManager;
    }

    [HttpGet("currentUser")]
    [Authorize]
    public async Task<ActionResult<UserReadDto>> GetCurrentUser()
    {
        var email = HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?
        .Value;
        Console.Write(email);
        var user = await _userManager.FindByEmailAsync(email);
        var userResponse = _mapper.Map<UserReadDto>(user);
        return Ok(userResponse);
    }

    [HttpPost("register")]
    public async Task<ActionResult<AuthResponseDto>> Register([FromBody] UserRegisterDto userRegisterDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var userAlreadyExists = await _authManager.CheckUserExists(userRegisterDto.Email);
        if (userAlreadyExists) return Conflict("User already exists");

        var user = _mapper.Map<User>(userRegisterDto);
        user.UserName = userRegisterDto.Email;
        var result = await _userManager.CreateAsync(user, userRegisterDto.Password);

        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }
            return BadRequest(ModelState);
        }

        var userResponse = _mapper.Map<UserReadDto>(user); 
        var token = await _authManager.GenerateToken(user);

        return StatusCode(201, new AuthResponseDto
        {
            User = userResponse,
            Token = token,
            Message = "Successfully signed up!"
        });

    }

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponseDto>> Login([FromBody] UserLoginDto userLoginDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var isValidUser = await _authManager.ValidateUser(userLoginDto);
        if (!isValidUser) return Unauthorized("Invalid credentials");

        var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
        var userResponse = _mapper.Map<UserReadDto>(user);
        var token = await _authManager.GenerateToken(user);

        return Ok(new AuthResponseDto
        {
            User = userResponse,
            Token = token,
            Message = "Successfully logged in!"
        });

    }

}