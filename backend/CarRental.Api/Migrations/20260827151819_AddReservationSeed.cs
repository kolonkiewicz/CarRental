using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 1, 27, new DateOnly(2026, 6, 12), new DateOnly(2026, 6, 7), 1745m, 4 },
                    { 2, 18, new DateOnly(2026, 5, 29), new DateOnly(2026, 5, 26), 2397m, 1 },
                    { 3, 28, new DateOnly(2026, 8, 7), new DateOnly(2026, 8, 3), 2196m, 6 },
                    { 4, 14, new DateOnly(2026, 8, 15), new DateOnly(2026, 8, 13), 2398m, 6 },
                    { 5, 25, new DateOnly(2026, 7, 13), new DateOnly(2026, 7, 9), 1476m, 2 },
                    { 6, 39, new DateOnly(2026, 6, 29), new DateOnly(2026, 6, 27), 658m, 5 },
                    { 7, 35, new DateOnly(2026, 8, 16), new DateOnly(2026, 8, 11), 4995m, 2 },
                    { 8, 36, new DateOnly(2026, 6, 8), new DateOnly(2026, 6, 1), 5593m, 5 },
                    { 9, 24, new DateOnly(2026, 8, 18), new DateOnly(2026, 8, 15), 1047m, 10 },
                    { 10, 3, new DateOnly(2026, 8, 16), new DateOnly(2026, 8, 12), 3996m, 4 },
                    { 11, 15, new DateOnly(2026, 7, 22), new DateOnly(2026, 7, 17), 9995m, 2 },
                    { 12, 30, new DateOnly(2026, 7, 10), new DateOnly(2026, 7, 7), 2097m, 6 },
                    { 13, 23, new DateOnly(2026, 7, 23), new DateOnly(2026, 7, 16), 2793m, 4 },
                    { 14, 45, new DateOnly(2026, 6, 6), new DateOnly(2026, 5, 31), 3894m, 2 },
                    { 15, 11, new DateOnly(2026, 7, 26), new DateOnly(2026, 7, 19), 9093m, 9 },
                    { 16, 11, new DateOnly(2026, 7, 23), new DateOnly(2026, 7, 18), 6495m, 8 },
                    { 17, 41, new DateOnly(2026, 5, 31), new DateOnly(2026, 5, 28), 1347m, 9 },
                    { 18, 21, new DateOnly(2026, 8, 22), new DateOnly(2026, 8, 19), 2097m, 1 },
                    { 19, 21, new DateOnly(2026, 8, 18), new DateOnly(2026, 8, 14), 2796m, 7 },
                    { 20, 14, new DateOnly(2026, 7, 17), new DateOnly(2026, 7, 10), 8393m, 10 },
                    { 21, 14, new DateOnly(2026, 6, 5), new DateOnly(2026, 5, 31), 5995m, 8 },
                    { 22, 30, new DateOnly(2026, 8, 9), new DateOnly(2026, 8, 5), 2796m, 3 },
                    { 23, 16, new DateOnly(2026, 7, 24), new DateOnly(2026, 7, 18), 5994m, 9 },
                    { 24, 48, new DateOnly(2026, 6, 13), new DateOnly(2026, 6, 8), 1495m, 10 },
                    { 25, 26, new DateOnly(2026, 8, 9), new DateOnly(2026, 8, 6), 897m, 6 },
                    { 26, 41, new DateOnly(2026, 8, 28), new DateOnly(2026, 8, 24), 1796m, 9 },
                    { 27, 8, new DateOnly(2026, 8, 29), new DateOnly(2026, 8, 27), 2198m, 1 },
                    { 28, 2, new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 22), 8091m, 3 },
                    { 29, 18, new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 27), 3196m, 10 },
                    { 30, 16, new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 23), 7992m, 7 },
                    { 31, 15, new DateOnly(2026, 9, 1), new DateOnly(2026, 8, 25), 13993m, 9 },
                    { 32, 9, new DateOnly(2026, 9, 2), new DateOnly(2026, 8, 22), 9889m, 1 },
                    { 33, 7, new DateOnly(2026, 9, 1), new DateOnly(2026, 8, 22), 8490m, 2 },
                    { 34, 35, new DateOnly(2026, 8, 30), new DateOnly(2026, 8, 22), 7992m, 5 },
                    { 35, 6, new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 25), 5994m, 2 },
                    { 36, 38, new DateOnly(2026, 8, 28), new DateOnly(2026, 8, 24), 1196m, 3 },
                    { 37, 28, new DateOnly(2026, 9, 3), new DateOnly(2026, 8, 23), 6039m, 5 },
                    { 38, 3, new DateOnly(2026, 8, 28), new DateOnly(2026, 8, 23), 4995m, 3 },
                    { 39, 48, new DateOnly(2026, 9, 1), new DateOnly(2026, 8, 22), 2990m, 5 },
                    { 40, 50, new DateOnly(2026, 8, 29), new DateOnly(2026, 8, 26), 897m, 10 },
                    { 41, 23, new DateOnly(2026, 9, 26), new DateOnly(2026, 9, 23), 1197m, 6 },
                    { 42, 24, new DateOnly(2026, 9, 29), new DateOnly(2026, 9, 23), 2094m, 9 },
                    { 43, 46, new DateOnly(2026, 9, 22), new DateOnly(2026, 9, 18), 4796m, 1 },
                    { 44, 4, new DateOnly(2026, 9, 1), new DateOnly(2026, 8, 30), 2798m, 8 },
                    { 45, 27, new DateOnly(2026, 9, 29), new DateOnly(2026, 9, 25), 1396m, 6 },
                    { 46, 13, new DateOnly(2026, 9, 3), new DateOnly(2026, 8, 31), 2697m, 4 },
                    { 47, 33, new DateOnly(2026, 9, 3), new DateOnly(2026, 9, 1), 1398m, 10 },
                    { 48, 31, new DateOnly(2026, 9, 27), new DateOnly(2026, 9, 25), 898m, 8 },
                    { 49, 42, new DateOnly(2026, 9, 26), new DateOnly(2026, 9, 23), 1497m, 9 },
                    { 50, 44, new DateOnly(2026, 9, 25), new DateOnly(2026, 9, 20), 3495m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 50);
        }
    }
}
