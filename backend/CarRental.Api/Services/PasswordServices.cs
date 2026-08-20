using Microsoft.AspNetCore.Identity;
using CarRental.Api.Models;

namespace CarRental.Api.Services;

public class PasswordService
{
    private readonly PasswordHasher<User> _passwordHasher = new();

    public string HashPassword(User user,string password)
    {
        return _passwordHasher.HashPassword(user, password);
    }

    public bool VerifyPassword(User user, string hashedPassword, string password)
    {
        var result = _passwordHasher.VerifyHashedPassword(
            user,
            hashedPassword,
            password);
        
        return result == PasswordVerificationResult.Success;
    }

}