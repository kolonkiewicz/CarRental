using Microsoft.AspNetCore;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CarRental.Api.Data;
using CarRental.Api.DTOs;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace CarRental.Controllers.Api
{
    [ApiController]
    [Route("api/cars")]
    public class CarsApiController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public CarsApiController(CarRentalDbContext context)
        {
            _context = context;
        }

        //GET   api/cars
        [HttpGet]
        public IActionResult GetAllCars()
        {
            var cars = _context.Cars
                .Select(c => new
                {
                    CarId = c.CarId,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    Description = c.Description,
                    PricePerDay = c.PricePerDay,
                    IsAvailable = c.IsAvailable
                }).ToList();
            return Ok(cars);
        }

        //GET    /api/cars/{id}
        [HttpGet("{id}")]
        public IActionResult GetCarId(int id)
        {
            var car = _context.Cars
                .Where(c => c.CarId == id)
                .Select(c => new
                {
                    CarId = c.CarId,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    Description = c.Description,
                    PricePerDay = c.PricePerDay,
                    IsAvailable = c.IsAvailable
                }).FirstOrDefault();
            if ( car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        //POST /api/cars
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateCar( CreateCarDto dto)
        {
            var car = new Car
            {
                Brand = dto.Brand,
                Model = dto.Model,
                Year = dto.Year,
                Description = dto.Description,
                PricePerDay = dto.PricePerDay,
                IsAvailable = dto.IsAvailable
            };

            _context.Cars.Add(car);
            _context.SaveChanges();

            return CreatedAtAction(
                nameof(GetCarId),
                new { id = car.CarId},
                car
            );
        }

        //PUT /api/cars/{id}
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult ChangeCar( int id, ChangeCarDto dto)
        {
            var car = _context.Cars.FirstOrDefault( c => c.CarId == id);

            if (car == null)
            {
                return NotFound();
            }

            car.Brand = dto.Brand;
            car.Model = dto.Model;
            car.Year = dto.Year;
            car.Description = dto.Description;
            car.PricePerDay = dto.PricePerDay;
            car.IsAvailable = dto.IsAvailable;

            _context.SaveChanges();

            return Ok(car);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteCar( int id)
        {
            var car = _context.Cars.FirstOrDefault( c => c.CarId == id);

             if ( car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            _context.SaveChanges();

            return NoContent();

        }

    }
}