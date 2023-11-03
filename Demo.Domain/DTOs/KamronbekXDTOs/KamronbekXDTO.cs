using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.DTOs.KamronbekXDTOs;

public class KamronbekXDTO
{
    [Required]
    public string Name { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public decimal Price { get; set; }
}
