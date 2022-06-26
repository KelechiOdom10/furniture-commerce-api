using API.DTOs.Auth;
using API.Entities;

namespace API.Interfaces;

public interface IAuthManagerRepository
{
    Task<bool> ValidateUser(UserLoginDto userLoginDto);
    Task<bool> CheckUserExists(string email);
    Task<string> GenerateToken(User user);
}