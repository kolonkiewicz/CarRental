using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PickupLocation",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReturnLocation",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "PickupLocation", "ReturnLocation" },
                values: new object[] { "Opole", "Warszawa" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 49, new DateOnly(2026, 7, 3), "Opole", "Opole", new DateOnly(2026, 6, 26), 2303m, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 10, new DateOnly(2026, 8, 13), "Warszawa", "Poznań", new DateOnly(2026, 8, 9), 5196m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice" },
                values: new object[] { 7, new DateOnly(2026, 6, 10), "Opole", "Warszawa", new DateOnly(2026, 6, 6), 3396m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 47, new DateOnly(2026, 8, 11), "Poznań", "Warszawa", new DateOnly(2026, 8, 5), 3894m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice" },
                values: new object[] { 36, new DateOnly(2026, 6, 8), "Opole", "Kraków", new DateOnly(2026, 6, 1), 5593m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice" },
                values: new object[] { 46, new DateOnly(2026, 6, 3), "Kraków", "Opole", new DateOnly(2026, 6, 1), 2398m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 6, new DateOnly(2026, 7, 9), "Opole", "Poznań", new DateOnly(2026, 7, 7), 1998m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 41, new DateOnly(2026, 7, 10), "Opole", "Kraków", new DateOnly(2026, 7, 7), 1347m, 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 43, new DateOnly(2026, 5, 31), "Warszawa", "Kraków", new DateOnly(2026, 5, 24), 3843m, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 35, new DateOnly(2026, 6, 28), "Poznań", "Opole", new DateOnly(2026, 6, 25), 2997m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 41, new DateOnly(2026, 5, 31), "Opole", "Warszawa", new DateOnly(2026, 5, 28), 1347m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 15, new DateOnly(2026, 7, 6), "Opole", "Warszawa", new DateOnly(2026, 7, 2), 7996m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 14, new DateOnly(2026, 7, 17), "Kraków", "Poznań", new DateOnly(2026, 7, 10), 8393m, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 26, new DateOnly(2026, 7, 24), "Kraków", "Kraków", new DateOnly(2026, 7, 21), 897m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "TotalPrice", "UserId" },
                values: new object[] { 48, new DateOnly(2026, 7, 24), "Poznań", "Poznań", 1794m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 24, new DateOnly(2026, 6, 22), "Poznań", "Warszawa", new DateOnly(2026, 6, 19), 1047m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice" },
                values: new object[] { 49, new DateOnly(2026, 8, 7), "Kraków", "Poznań", new DateOnly(2026, 8, 5), 658m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 39, new DateOnly(2026, 7, 9), "Poznań", "Opole", new DateOnly(2026, 7, 4), 1645m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 36, new DateOnly(2026, 8, 12), "Opole", "Opole", new DateOnly(2026, 8, 5), 5593m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 8, new DateOnly(2026, 8, 6), "Poznań", "Warszawa", new DateOnly(2026, 8, 1), 5495m, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 47, new DateOnly(2026, 8, 4), "Warszawa", "Opole", new DateOnly(2026, 7, 29), 3894m, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice" },
                values: new object[] { 41, new DateOnly(2026, 8, 1), "Kraków", "Opole", new DateOnly(2026, 7, 26), 2694m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 49, new DateOnly(2026, 6, 20), "Warszawa", "Opole", new DateOnly(2026, 6, 14), 1974m, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "CarId", "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 32, new DateOnly(2026, 7, 11), "Opole", "Kraków", new DateOnly(2026, 7, 9), 1998m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 1), "Warszawa", "Warszawa", new DateOnly(2026, 8, 26), 2694m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 3), "Kraków", "Kraków", 7693m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 29), "Opole", "Poznań", new DateOnly(2026, 8, 23), 5394m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 3), "Kraków", "Opole", new DateOnly(2026, 8, 23), 8789m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice" },
                values: new object[] { new DateOnly(2026, 9, 2), "Opole", "Poznań", new DateOnly(2026, 8, 22), 10989m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice" },
                values: new object[] { new DateOnly(2026, 8, 28), "Kraków", "Kraków", new DateOnly(2026, 8, 24), 7996m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 28), "Kraków", "Kraków", new DateOnly(2026, 8, 25), 2697m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 2), "Warszawa", "Kraków", new DateOnly(2026, 8, 27), 5094m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 3), "Opole", "Warszawa", new DateOnly(2026, 8, 27), 6993m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 30), "Poznań", "Kraków", new DateOnly(2026, 8, 26), 3996m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 2), "Poznań", "Kraków", new DateOnly(2026, 8, 26), 2093m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 29), "Warszawa", "Warszawa", new DateOnly(2026, 8, 24), 2745m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 31), "Poznań", "Poznań", new DateOnly(2026, 8, 25), 5994m, 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 2), "Warszawa", "Warszawa", 3289m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 30), "Warszawa", "Kraków", new DateOnly(2026, 8, 22), 2392m, 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 41,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 11), "Poznań", "Kraków", new DateOnly(2026, 9, 5), 2394m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 42,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 8), "Poznań", "Kraków", new DateOnly(2026, 9, 4), 1396m, 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 43,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 19), "Warszawa", "Warszawa", new DateOnly(2026, 9, 13), 7194m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 44,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 27), "Warszawa", "Kraków", new DateOnly(2026, 9, 25), 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 45,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 17), "Poznań", "Kraków", new DateOnly(2026, 9, 12), 1745m, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 46,
                columns: new[] { "PickupLocation", "ReturnLocation", "UserId" },
                values: new object[] { "Poznań", "Warszawa", 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 47,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 12), "Opole", "Poznań", new DateOnly(2026, 9, 7), 3495m, 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 48,
                columns: new[] { "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { "Poznań", "Kraków", new DateOnly(2026, 9, 20), 3143m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 49,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 11), "Warszawa", "Warszawa", new DateOnly(2026, 9, 8), 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 50,
                columns: new[] { "EndDate", "PickupLocation", "ReturnLocation", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 2), "Poznań", "Kraków", new DateOnly(2026, 8, 31), 1398m, 6 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickupLocation",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReturnLocation",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 18, new DateOnly(2026, 5, 29), new DateOnly(2026, 5, 26), 2397m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 28, new DateOnly(2026, 8, 7), new DateOnly(2026, 8, 3), 2196m, 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice" },
                values: new object[] { 14, new DateOnly(2026, 8, 15), new DateOnly(2026, 8, 13), 2398m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 25, new DateOnly(2026, 7, 13), new DateOnly(2026, 7, 9), 1476m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice" },
                values: new object[] { 39, new DateOnly(2026, 6, 29), new DateOnly(2026, 6, 27), 658m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice" },
                values: new object[] { 35, new DateOnly(2026, 8, 16), new DateOnly(2026, 8, 11), 4995m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 36, new DateOnly(2026, 6, 8), new DateOnly(2026, 6, 1), 5593m, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 24, new DateOnly(2026, 8, 18), new DateOnly(2026, 8, 15), 1047m, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 3, new DateOnly(2026, 8, 16), new DateOnly(2026, 8, 12), 3996m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 11,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 15, new DateOnly(2026, 7, 22), new DateOnly(2026, 7, 17), 9995m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 12,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 30, new DateOnly(2026, 7, 10), new DateOnly(2026, 7, 7), 2097m, 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 13,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 23, new DateOnly(2026, 7, 23), new DateOnly(2026, 7, 16), 2793m, 4 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 14,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 45, new DateOnly(2026, 6, 6), new DateOnly(2026, 5, 31), 3894m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 15,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 11, new DateOnly(2026, 7, 26), new DateOnly(2026, 7, 19), 9093m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 16,
                columns: new[] { "CarId", "EndDate", "TotalPrice", "UserId" },
                values: new object[] { 11, new DateOnly(2026, 7, 23), 6495m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 17,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 41, new DateOnly(2026, 5, 31), new DateOnly(2026, 5, 28), 1347m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 18,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice" },
                values: new object[] { 21, new DateOnly(2026, 8, 22), new DateOnly(2026, 8, 19), 2097m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 19,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 21, new DateOnly(2026, 8, 18), new DateOnly(2026, 8, 14), 2796m, 7 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 20,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 14, new DateOnly(2026, 7, 17), new DateOnly(2026, 7, 10), 8393m, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 21,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 14, new DateOnly(2026, 6, 5), new DateOnly(2026, 5, 31), 5995m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 22,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 30, new DateOnly(2026, 8, 9), new DateOnly(2026, 8, 5), 2796m, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 23,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice" },
                values: new object[] { 16, new DateOnly(2026, 7, 24), new DateOnly(2026, 7, 18), 5994m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 24,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 48, new DateOnly(2026, 6, 13), new DateOnly(2026, 6, 8), 1495m, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 25,
                columns: new[] { "CarId", "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { 26, new DateOnly(2026, 8, 9), new DateOnly(2026, 8, 6), 897m, 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 28), new DateOnly(2026, 8, 24), 1796m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 27,
                columns: new[] { "EndDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 29), 2198m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 28,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 22), 8091m, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 29,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 27), 3196m, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate", "TotalPrice" },
                values: new object[] { new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 23), 7992m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate", "TotalPrice" },
                values: new object[] { new DateOnly(2026, 9, 1), new DateOnly(2026, 8, 25), 13993m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 32,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 2), new DateOnly(2026, 8, 22), 9889m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 33,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 1), new DateOnly(2026, 8, 22), 8490m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 34,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 30), new DateOnly(2026, 8, 22), 7992m, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 35,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 31), new DateOnly(2026, 8, 25), 5994m, 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 36,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 28), new DateOnly(2026, 8, 24), 1196m, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 3), new DateOnly(2026, 8, 23), 6039m, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 38,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 28), new DateOnly(2026, 8, 23), 4995m, 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 39,
                columns: new[] { "EndDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 1), 2990m, 5 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 40,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 8, 29), new DateOnly(2026, 8, 26), 897m, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 41,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 26), new DateOnly(2026, 9, 23), 1197m, 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 42,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 29), new DateOnly(2026, 9, 23), 2094m, 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 22), new DateOnly(2026, 9, 18), 4796m, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 44,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 1), new DateOnly(2026, 8, 30), 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 45,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 29), new DateOnly(2026, 9, 25), 1396m, 6 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 46,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 47,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 3), new DateOnly(2026, 9, 1), 1398m, 10 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 48,
                columns: new[] { "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 25), 898m, 8 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 49,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 26), new DateOnly(2026, 9, 23), 9 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate", "TotalPrice", "UserId" },
                values: new object[] { new DateOnly(2026, 9, 25), new DateOnly(2026, 9, 20), 3495m, 3 });
        }
    }
}
