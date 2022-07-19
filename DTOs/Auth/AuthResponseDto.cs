using System.ComponentModel.DataAnnotations;
using API.DTOs.User;

namespace API.DTOs.Auth;

public class AuthResponseDto
{
    [Required]
    public UserReadDto User { get; set; }
    public string Message { get; init; } = string.Empty;
    [Required]
    public string Token { get; set; } = string.Empty;
}