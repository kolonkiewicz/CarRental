namespace CarRental.Api.Models;

public class Car
{
    public int CarId { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Year { get; set; }

    public int Seats { get; set; }

    public string FuelType { get; set; } = string.Empty;

    public string Transmission { get; set; } = string.Empty;

    public int Power { get; set; }

    public string Range { get; set; } = string.Empty;

    public decimal PricePerDay { get; set; }

    public double Rating { get; set; }

    public int ReviewsCount { get; set; }

    public bool IsFeatured { get; set; } = false;

    public string? Badge { get; set; }
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
