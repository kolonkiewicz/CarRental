using Microsoft.AspNetCore;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CarRental.Api.Data;
using CarRental.Api.DTOs;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Net.Sockets;

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
        [HttpPost]
        public IActionResult CreateReservation( CreateReservationDto dto)
        {
            var car = _context.Cars.FirstOrDefault( c => c.CarId == dto.CarId);

            if ( car == null)
            {
                return NotFound("Car not found.");
            }

            var days = ( dto.EndDate.ToDateTime(TimeOnly.MinValue) 
                - dto.StartDate.ToDateTime(TimeOnly.MinValue)).Days;
            
            if (days <= 0)
            {
                return BadRequest("End date must be after start date.");
            }

            var reservation = new Reservation
            {
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                CarId = dto.CarId
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return CreatedAtAction(
                nameof( GetReservationId ),
                new { id = reservation.ReservationId},
                reservation
            );
        }

        //GET    /api/reservations
        [HttpGet]
        public IActionResult GetAllReservations()
        {
            var reservations = _context.Reservations
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
         [HttpGet("{id}")]
        public IActionResult GetReservationId(int id)
        {
            var reservation = _context.Reservations
                .Where(r => r.ReservationId == id)
                .Select(r => new
                {
                    ReservationId = r.ReservationId,
                    startDate = r.StartDate,
                    EndDate = r.EndDate,
                    TotalPrice = r.TotalPrice,
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
                        PricePerDay = r.Car.PricePerDay,
                        IsAvailable = r.Car.IsAvailable
                    }
                })
                .FirstOrDefault();

            if ( reservation == null)
            {
                return NotFound();
            }
            return Ok(reservation);
        }
        //PUT    /api/reservations/{id}



        //DELETE /api/reservations/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReservation( int id)
        {
            var reservation = _context.Reservations.FirstOrDefault( r => r.ReservationId == id);

             if ( reservation == null)
            {
                return NotFound();
            }

            _context.Reservations.Remove(reservation);
            _context.SaveChanges();

            return NoContent();

        }

    }
}


