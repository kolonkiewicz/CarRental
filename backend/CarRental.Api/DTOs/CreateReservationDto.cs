namespace CarRental.Api.DTOs;

public class CreateReservationDto
{
    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int CarId { get; set; }

    public string PickupLocation { get; set; } = string.Empty;

    public string ReturnLocation { get; set; } = string.Empty;
}
