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
                    Id = c.CarId,
                    Brand = c.Brand,
                    Model = c.Model,
                    Category = c.Category,
                    ImageUrl = c.ImageUrl,
                    Year = c.Year,
                    Seats = c.Seats,
                    FuelType = c.FuelType,
                    Transmission = c.Transmission,
                    Power = c.Power,
                    Range = c.Range,
                    Description = c.Description,
                    PricePerDay = c.PricePerDay,
                    Rating = c.Rating,
                    ReviewsCount = c.ReviewsCount,
                    IsFeatured = c.IsFeatured,
                    IsAvailable = c.IsAvailable,
                    Badge = c.Badge
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
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        //POST /api/cars
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateCar(CreateCarDto dto)
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
                new { id = car.CarId },
                car
            );
        }

        //PUT /api/cars/{id}
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult ChangeCar(int id, ChangeCarDto dto)
        {
            var car = _context.Cars.FirstOrDefault(c => c.CarId == id);

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
        public IActionResult DeleteCar(int id)
        {
            var car = _context.Cars.FirstOrDefault(c => c.CarId == id);

            if (car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            _context.SaveChanges();

            return NoContent();
        }

        //GET   api/cars/categories
        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            var categories = _context.Cars
                .Select(c => c.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            return Ok(categories);
        }

        //get api/cars/price-range
        [HttpGet("price-range")]
        public async Task<IActionResult> GetPriceRange()
        {
            var minPrice = await _context.Cars.MinAsync(c => c.PricePerDay);

            var maxPrice = await _context.Cars.MaxAsync(c => c.PricePerDay);

            return Ok(new
            {
                minPrice,
                maxPrice
            });
        }

        //GET api/cars/fuels
        [HttpGet("fuels")]
        public async Task<IActionResult> GetFuels()
        {
            var fuels = await _context.Cars
                .Select(c => c.FuelType)
                .Distinct()
                .OrderBy(f => f)
                .ToListAsync();

            return Ok(fuels);
        }

        //GET api/cars/transmissions
        [HttpGet("transmissions")]
        public async Task<IActionResult> GetTransmissions()
        {
            var transmissions = await _context.Cars
                .Select(c => c.Transmission)
                .Distinct()
                .OrderBy(t => t)
                .ToListAsync();

            return Ok(transmissions);
        }

        //GET api/cars/seats
        [HttpGet("seats")]
        public async Task<IActionResult> GetSeats()
        {
            var seats = await _context.Cars
                .Select(c => c.Seats)
                .Distinct()
                .OrderBy(s => s)
                .ToListAsync();

            return Ok(seats);
        }

        //GET api/cars/seats
        [HttpGet("featured")]
        public async Task<IActionResult> GetFeaturedCars()
        {
            var cars = await _context.Cars
                .Where( c => c.IsFeatured)
                .Select( c => new
                {
                    Id = c.CarId,
                    Brand = c.Brand,
                    Model = c.Model,
                    Category = c.Category,
                    ImageUrl = c.ImageUrl,
                    Year = c.Year,
                    Seats = c.Seats,
                    FuelType = c.FuelType,
                    Transmission = c.Transmission,
                    Power = c.Power,
                    Range = c.Range,
                    Description = c.Description,
                    PricePerDay = c.PricePerDay,
                    Rating = c.Rating,
                    ReviewsCount = c.ReviewsCount,
                    IsFeatured = c.IsFeatured,
                    IsAvailable = c.IsAvailable,
                    Badge = c.Badge
                })
                .ToListAsync();
            
            return Ok(cars);
        }

        //GET api/cars/count
        [HttpGet("count")]
        public async Task<IActionResult> GetCarsCount()
        {
            var count = await _context.Cars.CountAsync();

            return Ok(count);
        }

    }
}