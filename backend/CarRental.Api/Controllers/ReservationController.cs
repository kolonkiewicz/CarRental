using Microsoft.AspNetCore;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CarRental.Api.Data;
using CarRental.Api.DTOs;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace CarRental.Controllers.Api
{
    [ApiController]
    [Route("api/reservations")]
    public class ReservationsApiCOntroller : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public ReservationsApiCOntroller(CarRentalDbContext context)
        {
            _context = context;
        }

        //POST   /api/reservations
        [Authorize]
        [HttpPost]
        public IActionResult CreateReservation(CreateReservationDto dto)
        {
            var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userIdValue == null)
            {
                return Unauthorized();
            }

            if (!int.TryParse(userIdValue, out int userId))
            {
                return Unauthorized();
            }

            var car = _context.Cars
                .FirstOrDefault(c => c.CarId == dto.CarId);

            if (car == null)
            {
                return NotFound("Car not found.");
            }

            var days = (dto.EndDate.ToDateTime(TimeOnly.MinValue)
                - dto.StartDate.ToDateTime(TimeOnly.MinValue)).Days;


            if (days <= 0)
            {
                return BadRequest("End date must be after start date.");
            }

            var hasConflict = _context.Reservations.Any(r =>
                r.CarId == dto.CarId &&
                dto.StartDate <= r.EndDate.AddDays(1) &&
                dto.EndDate >= r.StartDate);

            if (hasConflict)
            {
                return BadRequest("Car cant be reserved in the same time");
            }

            var totalprice = car.PricePerDay * days;

            var reservation = new Reservation
            {
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                UserId = userId,
                CarId = dto.CarId,
                TotalPrice = totalprice
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return CreatedAtAction(
                nameof(GetReservationId),
                new { id = reservation.ReservationId },
                new
                {
                    ReservationId = reservation.ReservationId,
                    StartDate = reservation.StartDate,
                    EndDate = reservation.EndDate,
                    UserId = reservation.UserId,
                    CarId = reservation.CarId,
                    TotalPrice = reservation.TotalPrice
                }
            );
        }

        //GET    /api/reservations
        [Authorize]
        [HttpGet]
        public IActionResult GetAllReservations()
        {
            var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if(!int.TryParse(userIdValue, out int userId))
            {
                return Unauthorized();
            }

            var reservations = _context.Reservations
                .Where( r => User.IsInRole("Admin") || r.UserId ==userId )
                .Select(r => new
                {
                    ReservationId = r.ReservationId,
                    UserId = r.UserId,
                    CarId = r.CarId,
                    StartDate = r.StartDate,
                    EndDate = r.EndDate,
                    TotalPrice = r.TotalPrice
                }).ToList();
            return Ok(reservations);
        }

        //GET    /api/reservations/{id}
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetReservationId(int id)
        {
            var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(userIdValue, out int userId))
            {
                return Unauthorized();
            }

            var reservation = _context.Reservations
                .Where(r => r.ReservationId == id)
                .Select(r => new
                {
                    ReservationId = r.ReservationId,
                    startDate = r.StartDate,
                    EndDate = r.EndDate,
                    TotalPrice = r.TotalPrice,
                    userId = r.UserId,
                    User = new
                    {
                        Firstname = r.User.FirstName,
                        Surname = r.User.Surname,
                        Email = r.User.Email,
                        Phone = r.User.Phone
                    },
                    Car = new
                    {
                        Brand = r.Car.Brand,
                        Model = r.Car.Model,
                        Year = r.Car.Year,
                        Description = r.Car.Description,
                        PricePerDay = r.Car.PricePerDay
                    }
                })
                .FirstOrDefault();

            if (reservation == null)
            {
                return NotFound();
            }

            if ( reservation.userId != userId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            return Ok(reservation);
        }

        //PUT    /api/reservations/{id}
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult ChangeReservation( int id, ChangeReservationDto dto)
        {
            var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(userIdValue, out int userId))
            {
                return Unauthorized();
            }

            var reservation = _context.Reservations
                .FirstOrDefault( r=> 
                    r.ReservationId == id &&
                    (User.IsInRole("Admin") || r.UserId == userId));
                
        
            if ( reservation == null )
            {
                return NotFound("Reservation not found.");
            }

            var car = _context.Cars
                .FirstOrDefault( c => c.CarId == dto.CarId);
            
            if ( car == null)
            {
                return NotFound("Car not found.");
            }

            
            
            var days = (dto.EndDate.ToDateTime(TimeOnly.MinValue)
                - dto.StartDate.ToDateTime(TimeOnly.MinValue)).Days;


            if (days <= 0)
            {
                return BadRequest("End date must be after start date.");
            }

            var hasConflict = _context.Reservations.Any(r =>
                r.ReservationId != id &&
                r.CarId == dto.CarId &&
                dto.StartDate <= r.EndDate.AddDays(1) &&
                dto.EndDate >= r.StartDate);

            if (hasConflict)
            {
                return BadRequest("Car cant be reserved in this period");
            }

            var totalprice = car.PricePerDay * days;

            reservation.StartDate = dto.StartDate;
            reservation.EndDate = dto.EndDate;
            reservation.CarId = dto.CarId;
            reservation.TotalPrice = totalprice;

            _context.SaveChanges();

            return Ok(new
            {
                ReservationId = reservation.ReservationId,
                UserId = reservation.UserId,
                CarId = reservation.CarId,
                StartDate = reservation.StartDate,
                EndDate = reservation.EndDate,
                TotalPrice = reservation.TotalPrice
            });
        }



        //DELETE /api/reservations/{id}
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteReservation(int id)
        {
            var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(userIdValue, out int userId))
            {
                return Unauthorized();
            }

            var reservation = _context.Reservations
                .FirstOrDefault( r=> 
                    r.ReservationId == id &&
                    (User.IsInRole("Admin") || r.UserId == userId));
                
            if( reservation == null)
            {
                return NotFound("Reservation not found.");
            }

            _context.Reservations.Remove(reservation);
            _context.SaveChanges();

            return NoContent();
        }
    }
}