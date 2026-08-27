namespace CarRental.Api.Models;

public class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string PasswordHashed { get; set; } = string.Empty;

    public string Role { get; set; } = "User";

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
