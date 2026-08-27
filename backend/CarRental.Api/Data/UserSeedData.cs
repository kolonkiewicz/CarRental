using CarRental.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Api.Data;

public static class UserSeedData
{
    public static void Seed(CarRentalDbContext context)
    {
        if (context.Users.Any())
            return;

        var passwordHasher = new PasswordHasher<User>();

        var users = new List<User>
        {
            new User
            {
                FirstName = "Adam",
                Surname = "Kowalski",
                Email = "adam.kowalski@velodrive.pl",
                Phone = "501234567",
                Role = "User"
            },

            new User
            {
                FirstName = "Anna",
                Surname = "Nowak",
                Email = "anna.nowak@velodrive.pl",
                Phone = "502345678",
                Role = "User"
            },

            new User
            {
                FirstName = "Piotr",
                Surname = "Wiśniewski",
                Email = "piotr.wisniewski@velodrive.pl",
                Phone = "503456789",
                Role = "User"
            },

            new User
            {
                FirstName = "Kamil",
                Surname = "Wójcik",
                Email = "kamil.wojcik@velodrive.pl",
                Phone = "504567890",
                Role = "User"
            },

            new User
            {
                FirstName = "Wisława",
                Surname = "Maciejewska",
                Email = "wisława.maciejewska@velodrive.pl",
                Phone = "697653501",
                Role = "User"
            },

            new User
            {
                FirstName = "Metody",
                Surname = "Jaworski",
                Email = "metody.jaworski@velodrive.pl",
                Phone = "722713839",
                Role = "User"
            },

            new User
            {
                FirstName = "Wioletta",
                Surname = "Sobczak",
                Email = "wioletta.sobczak@velodrive.pl",
                Phone = "784448593",
                Role = "User"
            },

            new User
            {
                FirstName = "Teodozja",
                Surname = "Borkowska",
                Email = "teodozja.borkowska@velodrive.pl",
                Phone = "518056828",
                Role = "User"
            },

            new User
            {
                FirstName = "Gustaw",
                Surname = "Tomaszewski",
                Email = "gustaw.tomaszewski@velodrive.pl",
                Phone = "887701355",
                Role = "User"
            },

            new User
            {
                FirstName = "Celestyna",
                Surname = "Sokołowska",
                Email = "celestyna.sokołowska@velodrive.pl",
                Phone = "721658041",
                Role = "User"
            },

            new User
            {
                FirstName = "Mateusz",
                Surname = "Admin",
                Email = "admin@velodrive.pl",
                Phone = "506789012",
                Role = "Admin"
            }
        };

        foreach (var user in users)
        {
            var password = user.Role == "Admin"
                ? "Admin123!"
                : "User123!";

            user.PasswordHashed = passwordHasher.HashPassword(
                user,
                password
            );
        }

        context.Users.AddRange(users);
        context.SaveChanges();
    }
}