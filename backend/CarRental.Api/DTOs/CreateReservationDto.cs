namespace CarRental.Api.Models;

public class CreateReservationDto
{
    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int CarId { get; set; }
}
