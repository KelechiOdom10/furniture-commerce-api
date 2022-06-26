using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class User : IdentityUser
{
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public string Role { get; set; } = Roles.User;
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}

public static class Roles
{
    public const string Admin = "Admin";
    public const string User = "User";
}