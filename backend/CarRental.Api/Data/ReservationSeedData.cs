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
                TotalPrice = 1745
            },
            new Reservation
            {
                ReservationId = 2,
                UserId = 1,
                CarId = 18,
                StartDate = new DateOnly(2026, 5, 26),
                EndDate = new DateOnly(2026, 5, 29),
                TotalPrice = 2397
            },
            new Reservation
            {
                ReservationId = 3,
                UserId = 6,
                CarId = 28,
                StartDate = new DateOnly(2026, 8, 3),
                EndDate = new DateOnly(2026, 8, 7),
                TotalPrice = 2196
            },
            new Reservation
            {
                ReservationId = 4,
                UserId = 6,
                CarId = 14,
                StartDate = new DateOnly(2026, 8, 13),
                EndDate = new DateOnly(2026, 8, 15),
                TotalPrice = 2398
            },
            new Reservation
            {
                ReservationId = 5,
                UserId = 2,
                CarId = 25,
                StartDate = new DateOnly(2026, 7, 9),
                EndDate = new DateOnly(2026, 7, 13),
                TotalPrice = 1476
            },
            new Reservation
            {
                ReservationId = 6,
                UserId = 5,
                CarId = 39,
                StartDate = new DateOnly(2026, 6, 27),
                EndDate = new DateOnly(2026, 6, 29),
                TotalPrice = 658
            },
            new Reservation
            {
                ReservationId = 7,
                UserId = 2,
                CarId = 35,
                StartDate = new DateOnly(2026, 8, 11),
                EndDate = new DateOnly(2026, 8, 16),
                TotalPrice = 4995
            },
            new Reservation
            {
                ReservationId = 8,
                UserId = 5,
                CarId = 36,
                StartDate = new DateOnly(2026, 6, 1),
                EndDate = new DateOnly(2026, 6, 8),
                TotalPrice = 5593
            },
            new Reservation
            {
                ReservationId = 9,
                UserId = 10,
                CarId = 24,
                StartDate = new DateOnly(2026, 8, 15),
                EndDate = new DateOnly(2026, 8, 18),
                TotalPrice = 1047
            },
            new Reservation
            {
                ReservationId = 10,
                UserId = 4,
                CarId = 3,
                StartDate = new DateOnly(2026, 8, 12),
                EndDate = new DateOnly(2026, 8, 16),
                TotalPrice = 3996
            },
            new Reservation
            {
                ReservationId = 11,
                UserId = 2,
                CarId = 15,
                StartDate = new DateOnly(2026, 7, 17),
                EndDate = new DateOnly(2026, 7, 22),
                TotalPrice = 9995
            },
            new Reservation
            {
                ReservationId = 12,
                UserId = 6,
                CarId = 30,
                StartDate = new DateOnly(2026, 7, 7),
                EndDate = new DateOnly(2026, 7, 10),
                TotalPrice = 2097
            },
            new Reservation
            {
                ReservationId = 13,
                UserId = 4,
                CarId = 23,
                StartDate = new DateOnly(2026, 7, 16),
                EndDate = new DateOnly(2026, 7, 23),
                TotalPrice = 2793
            },
            new Reservation
            {
                ReservationId = 14,
                UserId = 2,
                CarId = 45,
                StartDate = new DateOnly(2026, 5, 31),
                EndDate = new DateOnly(2026, 6, 6),
                TotalPrice = 3894
            },
            new Reservation
            {
                ReservationId = 15,
                UserId = 9,
                CarId = 11,
                StartDate = new DateOnly(2026, 7, 19),
                EndDate = new DateOnly(2026, 7, 26),
                TotalPrice = 9093
            },
            new Reservation
            {
                ReservationId = 16,
                UserId = 8,
                CarId = 11,
                StartDate = new DateOnly(2026, 7, 18),
                EndDate = new DateOnly(2026, 7, 23),
                TotalPrice = 6495
            },
            new Reservation
            {
                ReservationId = 17,
                UserId = 9,
                CarId = 41,
                StartDate = new DateOnly(2026, 5, 28),
                EndDate = new DateOnly(2026, 5, 31),
                TotalPrice = 1347
            },
            new Reservation
            {
                ReservationId = 18,
                UserId = 1,
                CarId = 21,
                StartDate = new DateOnly(2026, 8, 19),
                EndDate = new DateOnly(2026, 8, 22),
                TotalPrice = 2097
            },
            new Reservation
            {
                ReservationId = 19,
                UserId = 7,
                CarId = 21,
                StartDate = new DateOnly(2026, 8, 14),
                EndDate = new DateOnly(2026, 8, 18),
                TotalPrice = 2796
            },
            new Reservation
            {
                ReservationId = 20,
                UserId = 10,
                CarId = 14,
                StartDate = new DateOnly(2026, 7, 10),
                EndDate = new DateOnly(2026, 7, 17),
                TotalPrice = 8393
            },
            new Reservation
            {
                ReservationId = 21,
                UserId = 8,
                CarId = 14,
                StartDate = new DateOnly(2026, 5, 31),
                EndDate = new DateOnly(2026, 6, 5),
                TotalPrice = 5995
            },
            new Reservation
            {
                ReservationId = 22,
                UserId = 3,
                CarId = 30,
                StartDate = new DateOnly(2026, 8, 5),
                EndDate = new DateOnly(2026, 8, 9),
                TotalPrice = 2796
            },
            new Reservation
            {
                ReservationId = 23,
                UserId = 9,
                CarId = 16,
                StartDate = new DateOnly(2026, 7, 18),
                EndDate = new DateOnly(2026, 7, 24),
                TotalPrice = 5994
            },
            new Reservation
            {
                ReservationId = 24,
                UserId = 10,
                CarId = 48,
                StartDate = new DateOnly(2026, 6, 8),
                EndDate = new DateOnly(2026, 6, 13),
                TotalPrice = 1495
            },
            new Reservation
            {
                ReservationId = 25,
                UserId = 6,
                CarId = 26,
                StartDate = new DateOnly(2026, 8, 6),
                EndDate = new DateOnly(2026, 8, 9),
                TotalPrice = 897
            },
            new Reservation
            {
                ReservationId = 26,
                UserId = 9,
                CarId = 41,
                StartDate = new DateOnly(2026, 8, 24),
                EndDate = new DateOnly(2026, 8, 28),
                TotalPrice = 1796
            },
            new Reservation
            {
                ReservationId = 27,
                UserId = 1,
                CarId = 8,
                StartDate = new DateOnly(2026, 8, 27),
                EndDate = new DateOnly(2026, 8, 29),
                TotalPrice = 2198
            },
            new Reservation
            {
                ReservationId = 28,
                UserId = 3,
                CarId = 2,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 8, 31),
                TotalPrice = 8091
            },
            new Reservation
            {
                ReservationId = 29,
                UserId = 10,
                CarId = 18,
                StartDate = new DateOnly(2026, 8, 27),
                EndDate = new DateOnly(2026, 8, 31),
                TotalPrice = 3196
            },
            new Reservation
            {
                ReservationId = 30,
                UserId = 7,
                CarId = 16,
                StartDate = new DateOnly(2026, 8, 23),
                EndDate = new DateOnly(2026, 8, 31),
                TotalPrice = 7992
            },
            new Reservation
            {
                ReservationId = 31,
                UserId = 9,
                CarId = 15,
                StartDate = new DateOnly(2026, 8, 25),
                EndDate = new DateOnly(2026, 9, 1),
                TotalPrice = 13993
            },
            new Reservation
            {
                ReservationId = 32,
                UserId = 1,
                CarId = 9,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 9, 2),
                TotalPrice = 9889
            },
            new Reservation
            {
                ReservationId = 33,
                UserId = 2,
                CarId = 7,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 9, 1),
                TotalPrice = 8490
            },
            new Reservation
            {
                ReservationId = 34,
                UserId = 5,
                CarId = 35,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 8, 30),
                TotalPrice = 7992
            },
            new Reservation
            {
                ReservationId = 35,
                UserId = 2,
                CarId = 6,
                StartDate = new DateOnly(2026, 8, 25),
                EndDate = new DateOnly(2026, 8, 31),
                TotalPrice = 5994
            },
            new Reservation
            {
                ReservationId = 36,
                UserId = 3,
                CarId = 38,
                StartDate = new DateOnly(2026, 8, 24),
                EndDate = new DateOnly(2026, 8, 28),
                TotalPrice = 1196
            },
            new Reservation
            {
                ReservationId = 37,
                UserId = 5,
                CarId = 28,
                StartDate = new DateOnly(2026, 8, 23),
                EndDate = new DateOnly(2026, 9, 3),
                TotalPrice = 6039
            },
            new Reservation
            {
                ReservationId = 38,
                UserId = 3,
                CarId = 3,
                StartDate = new DateOnly(2026, 8, 23),
                EndDate = new DateOnly(2026, 8, 28),
                TotalPrice = 4995
            },
            new Reservation
            {
                ReservationId = 39,
                UserId = 5,
                CarId = 48,
                StartDate = new DateOnly(2026, 8, 22),
                EndDate = new DateOnly(2026, 9, 1),
                TotalPrice = 2990
            },
            new Reservation
            {
                ReservationId = 40,
                UserId = 10,
                CarId = 50,
                StartDate = new DateOnly(2026, 8, 26),
                EndDate = new DateOnly(2026, 8, 29),
                TotalPrice = 897
            },
            new Reservation
            {
                ReservationId = 41,
                UserId = 6,
                CarId = 23,
                StartDate = new DateOnly(2026, 9, 23),
                EndDate = new DateOnly(2026, 9, 26),
                TotalPrice = 1197
            },
            new Reservation
            {
                ReservationId = 42,
                UserId = 9,
                CarId = 24,
                StartDate = new DateOnly(2026, 9, 23),
                EndDate = new DateOnly(2026, 9, 29),
                TotalPrice = 2094
            },
            new Reservation
            {
                ReservationId = 43,
                UserId = 1,
                CarId = 46,
                StartDate = new DateOnly(2026, 9, 18),
                EndDate = new DateOnly(2026, 9, 22),
                TotalPrice = 4796
            },
            new Reservation
            {
                ReservationId = 44,
                UserId = 8,
                CarId = 4,
                StartDate = new DateOnly(2026, 8, 30),
                EndDate = new DateOnly(2026, 9, 1),
                TotalPrice = 2798
            },
            new Reservation
            {
                ReservationId = 45,
                UserId = 6,
                CarId = 27,
                StartDate = new DateOnly(2026, 9, 25),
                EndDate = new DateOnly(2026, 9, 29),
                TotalPrice = 1396
            },
            new Reservation
            {
                ReservationId = 46,
                UserId = 4,
                CarId = 13,
                StartDate = new DateOnly(2026, 8, 31),
                EndDate = new DateOnly(2026, 9, 3),
                TotalPrice = 2697
            },
            new Reservation
            {
                ReservationId = 47,
                UserId = 10,
                CarId = 33,
                StartDate = new DateOnly(2026, 9, 1),
                EndDate = new DateOnly(2026, 9, 3),
                TotalPrice = 1398
            },
            new Reservation
            {
                ReservationId = 48,
                UserId = 8,
                CarId = 31,
                StartDate = new DateOnly(2026, 9, 25),
                EndDate = new DateOnly(2026, 9, 27),
                TotalPrice = 898
            },
            new Reservation
            {
                ReservationId = 49,
                UserId = 9,
                CarId = 42,
                StartDate = new DateOnly(2026, 9, 23),
                EndDate = new DateOnly(2026, 9, 26),
                TotalPrice = 1497
            },
            new Reservation
            {
                ReservationId = 50,
                UserId = 3,
                CarId = 44,
                StartDate = new DateOnly(2026, 9, 20),
                EndDate = new DateOnly(2026, 9, 25),
                TotalPrice = 3495
            }
        );
    }
}