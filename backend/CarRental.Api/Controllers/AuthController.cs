using Microsoft.AspNetCore;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CarRental.Api.Data;
using CarRental.Api.DTOs;
using System.Diagnostics;
using CarRental.Api.Services;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace CarRental.Controllers.Api
{
    [ApiController]
    [Route("api/auth")]
    public class AuthApiController : ControllerBase
    {
        private readonly CarRentalDbContext _context;
        private readonly PasswordService _passwordService;
        private readonly JwtService _jwtservice;

        public AuthApiController(
            CarRentalDbContext context,
            PasswordService passwordService,
            JwtService jwtService)
        {
            _context = context;
            _passwordService = passwordService;
            _jwtservice = jwtService;
        }

        //POST /api/auth/register
        [HttpPost("register")]
        public IActionResult Register( RegisterDto dto )
        {
            var existingUser = _context.Users
                .FirstOrDefault( u => u.Email == dto.Email);

            if (existingUser != null)
            {
                return Conflict("User with this email already exists.");
            }

            var user = new User
            {
                FirstName = dto.FirstName,
                Surname = dto.Surname,
                Email = dto.Email,
                Phone = dto.Phone,
                Role = "User"
            };

            user.PasswordHashed = _passwordService.HashPassword(
                user, 
                dto.Password
            );

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Account created sucesfully"
            });
        }

        //POST /api/auth/login
        [HttpPost("login")]
        public IActionResult Login( LoginDto dto)
        {
            var exisitngUser = _context.Users
                .FirstOrDefault( u => u.Email == dto.Email );
            
            if ( exisitngUser == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            var veryficationresult = _passwordService.VerifyPassword(
                exisitngUser,
                exisitngUser.PasswordHashed,
                dto.Password
            );

            if (!veryficationresult)
            {
                return Unauthorized("Invalid email or password.");
            }
            
            var token = _jwtservice.GenerateToken(exisitngUser);

            return Ok(new
            {
                token,
                user = new
                {
                    exisitngUser.UserId,
                    exisitngUser.FirstName,
                    exisitngUser.Surname,
                    exisitngUser.Email,
                    exisitngUser.Phone,
                    exisitngUser.Role
                }
            });
        }
    }
}

