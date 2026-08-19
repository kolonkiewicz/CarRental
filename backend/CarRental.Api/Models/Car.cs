namespace CarRental.Api.Models;

public class Car
{
    public int CarId { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public int Year { get; set; }

    public string Description { get; set; } = string.Empty;

    public decimal PricePerDay { get; set; }

    public bool IsAvailable { get; set; }

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
