namespace CarRental.Api.DTOs;

public class ChangeReservationDto
{
    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int CarId { get; set; }
}
