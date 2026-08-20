namespace CarRental.Api.DTOs;

public class UserListDto
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public int ReservationCount { get; set; }

    }
