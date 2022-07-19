using System.ComponentModel.DataAnnotations;

namespace API.DTOs.User;

public class UserReadDto
{
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required] 
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Role { get; set; }
    
}