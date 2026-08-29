namespace CarRental.Api.DTOs;
public class ReservationDto
{
    public int ReservationId { get; set; }

    public ReservationCarDto Car { get; set; } = new();

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string PickupLocation { get; set; } = string.Empty;

    public string ReturnLocation { get; set; } = string.Empty;

    public decimal TotalPrice { get; set; }

    public string Status { get; set;} = string.Empty;
}

public class ReservationCarDto
{
    public int CarId { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;
    public decimal PricePerDay { get; set; }
}