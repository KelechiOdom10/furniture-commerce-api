using System.ComponentModel.DataAnnotations;
using API.Entities;

namespace API.DTOs.Auth;

public class UserRegisterDto
{
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$", ErrorMessage = "Password must be at least 6 characters long and contain at least one number and one letter")]
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = Roles.User;

}