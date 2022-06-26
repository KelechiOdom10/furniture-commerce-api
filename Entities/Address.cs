using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class Address : BaseEntity
{
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public string Street { get; set; } = string.Empty;
    [Required]
    public string City { get; set; } = string.Empty;
    [Required]
    public string PostalCode { get; set; } = string.Empty;
    [Required]
    public string Country { get; set; } = string.Empty;
    [Required]
    public string UserId { get; set; } = string.Empty;
    public virtual User? User { get; set; }
}