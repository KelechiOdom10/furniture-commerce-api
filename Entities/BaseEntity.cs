using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; init; }
}