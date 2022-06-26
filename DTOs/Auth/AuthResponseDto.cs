namespace API.DTOs.Auth;

public class AuthResponseDto
{
    public string? Email { get; set; }
    public string Message { get; set; } = string.Empty;
    public string? Token { get; set; }
}