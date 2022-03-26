using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; init; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}