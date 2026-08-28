using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Api.Data;

public static class ReservationSeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>().HasData(

            new Reservation
            {
                ReservationId = 1,
                UserId = 4,
                CarId = 27,
                StartDate = new DateOnly(2026, 6, 7),
                EndDate = new DateOnly(2026, 6, 12),
                PickupLocation = "Opole",
                ReturnLocation = "Warszawa",
                TotalPrice = 1745
            },
            new Reservation
            {
                ReservationId = 2,
                UserId = 3,
                CarId = 49,
                StartDate = new DateOnly(2026, 6, 26),
                EndDate = new DateOnly(2026, 7, 3),
                PickupLocation = "Opole",
                ReturnLocation = "Opole",
                TotalPrice = 2303
            },
            new Reservation
            {
                ReservationId = 3,
                UserId = 4,
                CarId = 10,
                StartDate = new DateOnly(2026, 8, 9),
                EndDate = new DateOnly(2026, 8, 13),
                PickupLocation = "Warszawa",
                ReturnLocation = "Poznań",
                TotalPrice = 5196
            },
            new Reservation
            {
                ReservationId = 4,
                UserId = 6,
                CarId = 7,
                StartDate = new DateOnly(2026, 6, 6),
                EndDate = new DateOnly(2026, 6, 10),
                PickupLocation = "Opole",
                ReturnLocation = "Warszawa",
                TotalPrice = 3396
            },
            new Reservation
            {
                ReservationId = 5,
                UserId = 8,
                CarId = 47,
                StartDate = new DateOnly(2026, 8, 5),
                EndDate = new DateOnly(2026, 8, 11),
                PickupLocation = "Poznań",
                ReturnLocation = "Warszawa",
                TotalPrice = 3894
            },
            new Reservation
            {
                ReservationId = 6,
                UserId = 5,
                CarId = 36,
                StartDate = new DateOnly(2026, 6, 1),
                EndDate = new DateOnly(2026, 6, 8),
                PickupLocation = "Opole",
                ReturnLocation = "Kraków",
                TotalPrice = 5593
            },
            new Reservation
            {
                ReservationId = 7,
                UserId = 2,
                CarId = 46,
                StartDate = new DateOnly(2026, 6, 1),
                EndDate = new DateOnly(2026, 6, 3),
                PickupLocation = "Kraków",
                ReturnLocation = "Opole",
                TotalPrice = 2398
            },
            new Reservation
            {
                ReservationId = 8,
                UserId = 4,
                CarId = 6,
                StartDate = new DateOnly(2026, 7, 7),
                EndDate = new DateOnly(2026, 7, 9),
                PickupLocation = "Opole",
                ReturnLocation = "Poznań",
                TotalPrice = 1998
            },
            new Reservation
            {
                ReservationId = 9,
                UserId = 6,
                CarId = 41,
                StartDate = new DateOnly(2026, 7, 7),
                EndDate = new DateOnly(2026, 7, 10),
                PickupLocation = "Opole",
                ReturnLocation = "Kraków",
                TotalPrice = 1347
            },
            new Reservation
            {
                ReservationId = 10,
                UserId = 5,
                CarId = 43,
                StartDate = new DateOnly(2026, 5, 24),
                EndDate = new DateOnly(2026, 5, 31),
                PickupLocation = "Warszawa",
                ReturnLocation = "Kraków",
                TotalPrice = 3843
            },
            new Reservation
            {
                ReservationId = 11,
                UserId = 4,
                CarId = 35,
                StartDate = new DateOnly(2026, 6, 25),
                EndDate = new DateOnly(2026, 6, 28),
                PickupLocation = "Poznań",
                ReturnLocation = "Opole",
                TotalPrice = 2997
            },
            new Reservation
            {
                ReservationId = 12,
                UserId = 9,
                CarId = 41,
                StartDate = new DateOnly(2026, 5, 28),
                EndDate = new DateOnly(2026, 5, 31),
                PickupLocation = "Opole",
                ReturnLocation = "Warszawa",
                TotalPrice = 1347
            },
            new Reservation
            {
                ReservationId = 13,
                UserId = 1,
                CarId = 15,
                StartDate = new DateOnly(2026, 7, 2),
                EndDate = new DateOnly(2026, 7, 6),
                PickupLocation = "Opole",
                ReturnLocation = "Warszawa",
                TotalPrice = 7996
            },
            new Reservation
            {
                ReservationId = 14,
                UserId = 10,
                CarId = 14,
                StartDate = new DateOnly(2026, 7, 10),
                EndDate = new DateOnly(2026, 7, 17),
                PickupLocation = "Kraków",
                ReturnLocation = "Poznań",
                TotalPrice = 8393
            },
            new Reservation
            {
                ReservationId = 15,
                UserId = 8,
                CarId = 26,
                StartDate = new DateOnly(2026, 7, 21),
                EndDate = new DateOnly(2026, 7, 24),
                PickupLocation = "Kraków",
                ReturnLocation = "Kraków",
                TotalPrice = 897
            },
            new Reservation
            {
                ReservationId = 16,
                UserId = 9,
                CarId = 48,
                StartDate = new DateOnly(2026, 7, 18),
                EndDate = new DateOnly(2026, 7, 24),
                PickupLocation = "Poznań",
                ReturnLocation = "Poznań",
                TotalPrice = 1794
            },
            new Reservation
            {
                ReservationId = 17,
                UserId = 4,
                CarId = 24,
                StartDate = new DateOnly(2026, 6, 19),
                EndDate = new DateOnly(2026, 6, 22),
                PickupLocation = "Poznań",
                ReturnLocation = "Warszawa",
                TotalPrice = 1047
            },
            new Reservation
            {
                ReservationId = 18,
                UserId = 1,
                CarId = 49,
                StartDate = new DateOnly(2026, 8, 5),
                EndDate = new DateOnly(2026, 8, 7),
                PickupLocation = "Kraków",
                ReturnLocation = "Poznań",
                TotalPrice = 658
            },
            new Reservation
            {
                ReservationId = 19,
                UserId = 2,
                CarId = 39,
                StartDate = new DateOnly(2026, 7, 4),
                EndDate = new DateOnly(2026, 7, 9),
                PickupLocation = "Poznań",
                ReturnLocation = "Opole",
                TotalPrice = 1645
            },
            new Reservation
            {
                ReservationId = 20,
                UserId = 1,
                CarId = 36,
                StartDate = new DateOnly(2026, 8, 5),
                EndDate = new DateOnly(2026, 8, 12),
                PickupLocation = "Opole",
                ReturnLocation = "Opole",
                TotalPrice = 5593
            },
            new Reservation
            {
                ReservationId = 21,
                UserId = 5,
                CarId = 8,
                StartDate = new DateOnly(2026, 8, 1),
                EndDate = new DateOnly(2026, 8, 6),
                PickupLocation = "Poznań",
                ReturnLocation = "Warszawa",
                TotalPrice = 5495
            },
            new Reservation
            {
                ReservationId = 22,
                UserId = 5,
                CarId = 47,
                StartDate = new DateOnly(2026, 7, 29),
                EndDate = new DateOnly(2026, 8, 4),
                PickupLocation = "Warszawa",
                ReturnLocation = "Opole",
                TotalPrice = 3894
            },
            new Reservation
            {
                ReservationId = 23,
                UserId = 9,
                CarId = 41,
                StartDate = new DateOnly(2026, 7, 26),
                EndDate = new DateOnly(2026, 8, 1),
                PickupLocation = "Kraków",
                ReturnLocation = "Opole",
                TotalPrice = 2694
            },
            new Reservation
            {
                ReservationId = 24,
                UserId = 3,
                CarId = 49,
                StartDate = new DateOnly(2026, 6, 14),
                EndDate = new DateOnly(2026, 6, 20),
                PickupLocation = "Warszawa",
                ReturnLocation = "Opole",
                TotalPrice = 1974
            },
            new Reservation
            {
                ReservationId = 25,
                UserId = 1,
                CarId = 32,
                StartDate = new DateOnly(2026, 7, 9),
                EndDate = new DateOnly(2026, 7, 11),
                PickupLocation = "Opole",
                ReturnLocation = "Kraków",
                TotalPrice = 1998
            },
            new Reservation
            {
                ReservationId = 26,
                UserId = 1,
                CarId = 41,
                StartDate = new DateOnly(2026, 8, 26),
                EndDate = new DateOnly(2026, 9, 1),
                PickupLocation = "Warszawa",
                ReturnLocation = "Warszawa",
                TotalPrice = 2694
            },
            new Reservation
            {
                ReservationId = 27,
                UserId = 8,
                CarId = 8,
                StartDate = new DateOnly(2026, 8, 27),
                EndDate = new DateOnly(2026, 9, 3),
                PickupLocation = "Kraków",
                ReturnLocation = "Kraków",
                TotalPrice = 7693
            },
            new Reservation
            {
                ReservationId = 28,
                UserId = 8,
                CarId = 2,
                StartDate = new DateOnly(2026, 8, 23),
                EndDate = new DateOnly(2026, 8, 29),
                PickupLocation = "Opole",
                ReturnLocation = "Poznań",
                TotalPrice = 5394
            },
            new Reservation
            {
                ReservationId = 29,
                UserId = 4,
                CarId = 18,
                StartDate = new DateOnly(2026, 8, 23),
                EndDate = new DateOnly(2026, 9, 3),
                PickupLocation = "Kraków",
                ReturnLocation = "Opole",
                TotalPrice = 8789
            },
            new Reservation
            {
                ReservationId = 30,
                UserId = 7,
                CarId = 16,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 9, 2),
                PickupLocation = "Opole",
                ReturnLocation = "Poznań",
                TotalPrice = 10989
            },
            new Reservation
            {
                ReservationId = 31,
                UserId = 9,
                CarId = 15,
                StartDate = new DateOnly(2026, 8, 24),
                EndDate = new DateOnly(2026, 8, 28),
                PickupLocation = "Kraków",
                ReturnLocation = "Kraków",
                TotalPrice = 7996
            },
            new Reservation
            {
                ReservationId = 32,
                UserId = 2,
                CarId = 9,
                StartDate = new DateOnly(2026, 8, 25),
                EndDate = new DateOnly(2026, 8, 28),
                PickupLocation = "Kraków",
                ReturnLocation = "Kraków",
                TotalPrice = 2697
            },
            new Reservation
            {
                ReservationId = 33,
                UserId = 1,
                CarId = 7,
                StartDate = new DateOnly(2026, 8, 27),
                EndDate = new DateOnly(2026, 9, 2),
                PickupLocation = "Warszawa",
                ReturnLocation = "Kraków",
                TotalPrice = 5094
            },
            new Reservation
            {
                ReservationId = 34,
                UserId = 2,
                CarId = 35,
                StartDate = new DateOnly(2026, 8, 27),
                EndDate = new DateOnly(2026, 9, 3),
                PickupLocation = "Opole",
                ReturnLocation = "Warszawa",
                TotalPrice = 6993
            },
            new Reservation
            {
                ReservationId = 35,
                UserId = 9,
                CarId = 6,
                StartDate = new DateOnly(2026, 8, 26),
                EndDate = new DateOnly(2026, 8, 30),
                PickupLocation = "Poznań",
                ReturnLocation = "Kraków",
                TotalPrice = 3996
            },
            new Reservation
            {
                ReservationId = 36,
                UserId = 9,
                CarId = 38,
                StartDate = new DateOnly(2026, 8, 26),
                EndDate = new DateOnly(2026, 9, 2),
                PickupLocation = "Poznań",
                ReturnLocation = "Kraków",
                TotalPrice = 2093
            },
            new Reservation
            {
                ReservationId = 37,
                UserId = 8,
                CarId = 28,
                StartDate = new DateOnly(2026, 8, 24),
                EndDate = new DateOnly(2026, 8, 29),
                PickupLocation = "Warszawa",
                ReturnLocation = "Warszawa",
                TotalPrice = 2745
            },
            new Reservation
            {
                ReservationId = 38,
                UserId = 7,
                CarId = 3,
                StartDate = new DateOnly(2026, 8, 25),
                EndDate = new DateOnly(2026, 8, 31),
                PickupLocation = "Poznań",
                ReturnLocation = "Poznań",
                TotalPrice = 5994
            },
            new Reservation
            {
                ReservationId = 39,
                UserId = 1,
                CarId = 48,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 9, 2),
                PickupLocation = "Warszawa",
                ReturnLocation = "Warszawa",
                TotalPrice = 3289
            },
            new Reservation
            {
                ReservationId = 40,
                UserId = 7,
                CarId = 50,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 8, 30),
                PickupLocation = "Warszawa",
                ReturnLocation = "Kraków",
                TotalPrice = 2392
            },
            new Reservation
            {
                ReservationId = 41,
                UserId = 4,
                CarId = 23,
                StartDate = new DateOnly(2026, 9, 5),
                EndDate = new DateOnly(2026, 9, 11),
                PickupLocation = "Poznań",
                ReturnLocation = "Kraków",
                TotalPrice = 2394
            },
            new Reservation
            {
                ReservationId = 42,
                UserId = 7,
                CarId = 24,
                StartDate = new DateOnly(2026, 9, 4),
                EndDate = new DateOnly(2026, 9, 8),
                PickupLocation = "Poznań",
                ReturnLocation = "Kraków",
                TotalPrice = 1396
            },
            new Reservation
            {
                ReservationId = 43,
                UserId = 2,
                CarId = 46,
                StartDate = new DateOnly(2026, 9, 13),
                EndDate = new DateOnly(2026, 9, 19),
                PickupLocation = "Warszawa",
                ReturnLocation = "Warszawa",
                TotalPrice = 7194
            },
            new Reservation
            {
                ReservationId = 44,
                UserId = 9,
                CarId = 4,
                StartDate = new DateOnly(2026, 9, 25),
                EndDate = new DateOnly(2026, 9, 27),
                PickupLocation = "Warszawa",
                ReturnLocation = "Kraków",
                TotalPrice = 2798
            },
            new Reservation
            {
                ReservationId = 45,
                UserId = 3,
                CarId = 27,
                StartDate = new DateOnly(2026, 9, 12),
                EndDate = new DateOnly(2026, 9, 17),
                PickupLocation = "Poznań",
                ReturnLocation = "Kraków",
                TotalPrice = 1745
            },
            new Reservation
            {
                ReservationId = 46,
                UserId = 7,
                CarId = 13,
                StartDate = new DateOnly(2026, 8, 31),
                EndDate = new DateOnly(2026, 9, 3),
                PickupLocation = "Poznań",
                ReturnLocation = "Warszawa",
                TotalPrice = 2697
            },
            new Reservation
            {
                ReservationId = 47,
                UserId = 7,
                CarId = 33,
                StartDate = new DateOnly(2026, 9, 7),
                EndDate = new DateOnly(2026, 9, 12),
                PickupLocation = "Opole",
                ReturnLocation = "Poznań",
                TotalPrice = 3495
            },
            new Reservation
            {
                ReservationId = 48,
                UserId = 9,
                CarId = 31,
                StartDate = new DateOnly(2026, 9, 20),
                EndDate = new DateOnly(2026, 9, 27),
                PickupLocation = "Poznań",
                ReturnLocation = "Kraków",
                TotalPrice = 3143
            },
            new Reservation
            {
                ReservationId = 49,
                UserId = 4,
                CarId = 42,
                StartDate = new DateOnly(2026, 9, 8),
                EndDate = new DateOnly(2026, 9, 11),
                PickupLocation = "Warszawa",
                ReturnLocation = "Warszawa",
                TotalPrice = 1497
            },
            new Reservation
            {
                ReservationId = 50,
                UserId = 6,
                CarId = 44,
                StartDate = new DateOnly(2026, 8, 31),
                EndDate = new DateOnly(2026, 9, 2),
                PickupLocation = "Poznań",
                ReturnLocation = "Kraków",
                TotalPrice = 1398
            }
        );
    }
}