namespace CarRental.Api.DTOs;

public class AdminDashboardDto
{
    public int UsersCount { get; set; }
    public int ActiveReservations { get; set; }
    public int TotalReservations { get; set; }
    public decimal Revenue { get; set; }
    public int AvailableCars { get; set; }
    public int TotalCars { get; set; }
    public List<AdminReservationDto> RecentReservations { get; set; } = [];
}

public class AdminReservationDto
{
    public int ReservationId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CarName { get; set; } = string.Empty;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = string.Empty;
}

