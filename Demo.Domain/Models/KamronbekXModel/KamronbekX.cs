using Demo.Domain.BaseModels.Entities;
using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.Models.KamronbekXModel;

public class KamronbekX : BaseEntity
{
    [Required]
    public string Name { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public decimal Price { get; set; }
}
