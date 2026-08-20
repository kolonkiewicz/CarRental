using Microsoft.AspNetCore;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CarRental.Api.Data;
using CarRental.Api.DTOs;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace CarRental.Controllers.Api
{

    [ApiController]
    [Route("api/users")]
    public class UsersApiController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public UsersApiController(CarRentalDbContext context)
        {
            _context = context;
        }

        //GET    /api/users
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users
                .Select(u => new UserListDto
                {
                    UserId = u.UserId,
                    FirstName = u.FirstName,
                    Surname = u.Surname,
                    Email = u.Email,
                    Phone = u.Phone,
                    ReservationCount = u.Reservations.Count()
                }).ToList();
            return Ok(users);
        }
        
        //GET    /api/users/{id}
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public IActionResult GetUserId(int id)
        {
            var user = _context.Users
                .Where(u => u.UserId == id)
                .Select(u => new UserDetailsDto
                {
                    UserId = u.UserId,
                    FirstName = u.FirstName,
                    Surname = u.Surname,
                    Email = u.Email,
                    Phone = u.Phone,
                    Role = u.Role,
                    ReservationCount = u.Reservations.Count()
                }).FirstOrDefault();
            
            if ( user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        //PUT    /api/users/{id}
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateUser( int id, UpdateUserDto dto)
        {
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (currentUserId == null)
            {
                return Unauthorized();
            }

            var user = _context.Users.FirstOrDefault( u => u.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            var isAdmin = User.IsInRole("Admin");

            if (!isAdmin && user.UserId.ToString() != currentUserId)
            {
                return Forbid();
            }

            user.FirstName = dto.FirstName;
            user.Surname = dto.Surname;
            user.Email = dto.Email;
            user.Phone = dto.Phone;

            _context.SaveChanges();

            return Ok( new UserDetailsDto
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                Surname = user.Surname,
                Email = user.Email,
                Phone = user.Phone,
                ReservationCount = user.Reservations.Count()
            });
        }

        //DELETE /api/users/{id}
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteUser( int id)
        {
            var user = _context.Users.FirstOrDefault( u => u.UserId == id);

             if ( user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return NoContent();

        }
    }
    
}