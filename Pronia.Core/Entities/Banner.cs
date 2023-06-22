using Pronia.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Pronia.Core.Entities;

public class Banner : IEntity
{
    public int Id { get ; set ; }
    public string ImagePath { get; set; } = null!;
    [Required]
    public string Collection { get ; set ; }=null!;
    [Required]
    public string Title { get ; set ; }=null!;
    public string? ImageDesc { get ; set ; }
}
