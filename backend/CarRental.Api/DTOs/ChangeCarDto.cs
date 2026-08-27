using System.ComponentModel.DataAnnotations;

namespace CarRental.Api.DTOs;

public class ChangeCarDto
{
    [Required]
    [StringLength(50)]
    public string Brand { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Model { get; set; } = string.Empty;
    
    [Range(1900,2100)]
    public int Year { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Range(0.01,10000)]
    public decimal PricePerDay { get; set; }

}