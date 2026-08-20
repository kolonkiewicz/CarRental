namespace CarRental.Api.DTOs;

public class UserDetailsDto
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;

    public int ReservationCount { get; set; }

    }
