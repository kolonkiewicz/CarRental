using System.ComponentModel.DataAnnotations;

namespace CarRental.Api.DTOs;

public class CreateCarDto
{
    [Required]
    [StringLength(50)]
    public string Brand { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Model { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = string.Empty;

    [Required]
    public string ImageUrl { get; set; } = string.Empty;

    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Range(1900, 2100)]
    public int Year { get; set; }

    [Range(1, 9)]
    public int Seats { get; set; }

    [Required]
    [StringLength(30)]
    public string FuelType { get; set; } = string.Empty;

    [Required]
    [StringLength(30)]
    public string Transmission { get; set; } = string.Empty;

    [Range(0, 2000)]
    public int Power { get; set; }

    [StringLength(50)]
    public string Range { get; set; } = string.Empty;

    [Range(0.01, 10000)]
    public decimal PricePerDay { get; set; }

    public bool IsFeatured { get; set; }

    public bool IsAvailable { get; set; }

    [StringLength(50)]
    public string? Badge { get; set; }
}