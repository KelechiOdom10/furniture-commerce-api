using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class BaseDto
{
    [Required]
    public int Id { get; set; }
    [Required]
    public DateTimeOffset CreatedAt { get; set; }
}