namespace CarRental.Api.Models;

public class Reservation
{
    public int ReservationId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public decimal TotalPrice { get; set; }
    public string PickupLocation { get; set; } = string.Empty;
    public string ReturnLocation { get; set;} = string.Empty;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int CarId { get; set; }
    public Car Car { get; set; } = null!;
}
