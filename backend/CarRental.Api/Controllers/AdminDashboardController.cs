using CarRental.Api.Data;
using CarRental.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Controllers.Api
{
    [ApiController]
    [Route("api/admin/dashboard")]
    public class AdminDashboardApiController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public AdminDashboardApiController(CarRentalDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDashboard()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);

            var result = new AdminDashboardDto
            {
                UsersCount = _context.Users.Count(),

                TotalReservations = _context.Reservations.Count(),

                ActiveReservations = _context.Reservations.Count( r =>
                    r.StartDate <= today &&
                    r.EndDate >= today),
                
                Revenue = _context.Reservations
                    .Where( r => r.EndDate < today )
                    .Sum( r => (decimal?)r.TotalPrice) ?? 0,

                TotalCars = _context.Cars.Count(),

                AvailableCars = _context.Cars.Count( c =>
                    !c.Reservations.Any( r =>
                        r.StartDate <= today &&
                        r.EndDate >= today) ),
                
                RecentReservations = _context.Reservations
                    .Include(r => r.User)
                    .Include(r => r.Car)
                    .OrderByDescending( r => r.ReservationId)
                    .Take(5)
                    .Select( r => new AdminReservationDto
                    {
                        ReservationId = r.ReservationId,
                        CustomerName = r.User.FirstName + " " + r.User.Surname,
                        CarName = r.Car.Brand + " " + r.Car.Model,
                        StartDate = r.StartDate,
                        EndDate = r.EndDate,
                        TotalPrice = r.TotalPrice,

                        Status = r.StartDate <= today && r.EndDate >= today
                            ? "Aktywna"
                            : r.StartDate > today
                                ? "Nadchodzące"
                                : "Zakończona"
                    })
                    .ToList()
            };

            return Ok(result);
        }

    }
}