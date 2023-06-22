using Pronia.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Pronia.Core.Entities;

public class NewProduct : IEntity
{
    public int Id { get ; set ; }
    public string MainImagePath { get; set; } = null!;
    public string? HoverImagePath { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public decimal Price { get; set; }
    public int Rate { get; set; }
    [Required]
    public bool IsDeleted { get; set; }
}
