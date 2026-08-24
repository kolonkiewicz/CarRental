using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Badge",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Range",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ReviewsCount",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Badge", "Brand", "Category", "Description", "FuelType", "ImageUrl", "IsAvailable", "Model", "Power", "PricePerDay", "Range", "Rating", "ReviewsCount", "Seats", "Transmission", "Year" },
                values: new object[,]
                {
                    { 1, "Bestseller", "Porsche", "Sportowe", "Wyjątkowe sportowe coupe stworzone z myślą o maksymalnych osiągach i precyzyjnym prowadzeniu.", "Benzyna", "/images/cars/porsche-911-gt3.jpg", true, "911 GT3", 510, 1499m, "450 KM", 4.9000000000000004, 32, 2, "Automat", 2024 },
                    { 2, null, "Porsche", "Sportowe", "Lekki i dynamiczny samochód sportowy oferujący świetne prowadzenie oraz wyjątkowe wrażenia z jazdy.", "Benzyna", "/images/cars/porsche-718-cayman.jpg", true, "718 Cayman", 300, 899m, "350 KM", 4.7999999999999998, 24, 2, "Automat", 2024 },
                    { 3, "Hot", "BMW", "Sportowe", "Sportowy sedan łączący wysoką moc, agresywną stylistykę i komfort podczas codziennej jazdy.", "Benzyna", "/images/cars/bmw-m4.jpg", true, "M4 Competition", 510, 999m, "450 KM", 4.7999999999999998, 29, 4, "Automat", 2024 },
                    { 4, "Premium", "Mercedes-AMG", "Sportowe", "Luksusowe coupe AMG oferujące imponujące osiągi, komfort i charakterystyczny sportowy charakter.", "Benzyna", "/images/cars/mercedes-amg-gt.jpg", true, "GT", 585, 1399m, "500 KM", 4.9000000000000004, 18, 2, "Automat", 2024 },
                    { 5, "Ikona", "Audi", "Sportowe", "Legendarny supersamochód z silnikiem V10, który zapewnia wyjątkowe osiągi i niezapomniane emocje.", "Benzyna", "/images/cars/audi-r8.jpg", true, "R8 V10", 620, 1599m, "580 KM", 4.9000000000000004, 41, 2, "Automat", 2023 },
                    { 6, "Nowy", "BMW", "Sedan", "Mocny i komfortowy sedan klasy premium idealny zarówno na długie trasy, jak i dynamiczną jazdę.", "Benzyna", "/images/cars/bmw-m5.jpg", true, "M5 Competition", 625, 999m, "625 KM", 4.7999999999999998, 37, 5, "Automat", 2024 },
                    { 7, null, "Mercedes-Benz", "Sedan", "Elegancki sedan AMG łączący sportowe osiągi z wysokim komfortem i nowoczesnymi technologiami.", "Benzyna", "/images/cars/mercedes-e53.jpg", true, "E53 AMG", 435, 849m, "450 KM", 4.7000000000000002, 21, 5, "Automat", 2024 },
                    { 8, "Bestseller", "Audi", "Sedan", "Przestronne i niezwykle szybkie auto klasy premium oferujące połączenie praktyczności i osiągów.", "Benzyna", "/images/cars/audi-rs6.jpg", true, "RS6", 600, 1099m, "550 KM", 4.9000000000000004, 34, 5, "Automat", 2024 },
                    { 9, null, "BMW", "Sedan", "Dynamiczny sedan BMW oferujący sportowe prowadzenie, wysoką moc i komfort na co dzień.", "Benzyna", "/images/cars/bmw-m3.jpg", true, "M3", 510, 899m, "450 KM", 4.7999999999999998, 27, 5, "Automat", 2024 },
                    { 10, "Premium", "Mercedes-Benz", "Sedan", "Luksusowy sedan zapewniający wyjątkowy komfort jazdy, przestronne wnętrze i mocny silnik.", "Benzyna", "/images/cars/mercedes-s580.jpg", true, "S580", 503, 1299m, "500 KM", 4.9000000000000004, 19, 5, "Automat", 2024 },
                    { 11, "Premium", "Mercedes-AMG", "SUV", "Ikoniczny SUV AMG łączący luksus, terenowy charakter i imponujące osiągi.", "Benzyna", "/images/cars/g63.jpg", true, "G63", 585, 1299m, "585 KM", 4.9000000000000004, 45, 5, "Automat", 2024 },
                    { 12, "Hot", "BMW", "SUV", "Potężny SUV BMW oferujący sportowe osiągi, przestronne wnętrze i wysoki komfort podróżowania.", "Benzyna", "/images/cars/bmw-x5m.jpg", true, "X5 M Competition", 625, 1099m, "550 KM", 4.7999999999999998, 31, 5, "Automat", 2024 },
                    { 13, null, "Porsche", "SUV", "Luksusowy SUV Porsche zapewniający doskonałe prowadzenie, komfort oraz wszechstronność.", "Benzyna", "/images/cars/porsche-cayenne.jpg", true, "Cayenne", 353, 899m, "400 KM", 4.7999999999999998, 28, 5, "Automat", 2024 },
                    { 14, "Bestseller", "Audi", "SUV", "Sportowy SUV Audi łączący potężny silnik, luksusowe wnętrze i wyjątkową dynamikę.", "Benzyna", "/images/cars/audi-rsq8.jpg", true, "RS Q8", 600, 1199m, "550 KM", 4.9000000000000004, 26, 5, "Automat", 2024 },
                    { 15, "Ikona", "Lamborghini", "SUV", "Luksusowy supersuv Lamborghini oferujący ekstremalne osiągi i wyjątkowy charakter.", "Benzyna", "/images/cars/lamborghini-urus.jpg", true, "Urus", 666, 1999m, "650 KM", 5.0, 17, 5, "Automat", 2023 },
                    { 16, "Premium", "BMW", "Premium", "Luksusowa limuzyna BMW zapewniająca najwyższy komfort, nowoczesne technologie i dużą moc.", "Hybryda", "/images/cars/bmw-7.jpg", true, "7 Series", 571, 999m, "500 KM", 4.9000000000000004, 22, 5, "Automat", 2024 },
                    { 17, null, "Mercedes-Benz", "Premium", "Flagowy sedan Mercedesa stworzony z myślą o najwyższym poziomie komfortu i elegancji.", "Benzyna", "/images/cars/mercedes-s-class.jpg", true, "S-Class", 435, 1099m, "500 KM", 4.9000000000000004, 25, 5, "Automat", 2024 },
                    { 18, null, "Audi", "Premium", "Elegancka limuzyna Audi oferująca komfortowe wnętrze, nowoczesne technologie i spokojną jazdę.", "Diesel", "/images/cars/audi-a8.jpg", true, "A8", 286, 799m, "700 KM", 4.7000000000000002, 18, 5, "Automat", 2024 },
                    { 19, "Eco", "Tesla", "Elektryczne", "Elektryczny sedan o imponujących osiągach i dużym zasięgu, idealny na długie podróże.", "Elektryczny", "/images/cars/tesla-model-s.jpg", true, "Model S", 670, 899m, "634 KM", 4.7999999999999998, 36, 5, "Automat", 2024 },
                    { 20, "Eco", "Tesla", "Elektryczne", "Popularny elektryczny sedan oferujący świetny zasięg, dynamiczną jazdę i nowoczesne technologie.", "Elektryczny", "/images/cars/tesla-model-3.jpg", true, "Model 3", 513, 499m, "629 KM", 4.7000000000000002, 42, 5, "Automat", 2024 },
                    { 21, "Eco", "BMW", "Elektryczne", "Sportowy samochód elektryczny BMW łączący dynamiczne osiągi z komfortem codziennego użytkowania.", "Elektryczny", "/images/cars/bmw-i4.jpg", true, "i4 M50", 544, 699m, "510 KM", 4.7999999999999998, 23, 5, "Automat", 2024 },
                    { 22, "Premium", "Porsche", "Elektryczne", "Elektryczne Porsche oferujące sportowe osiągi, luksusowe wnętrze i szybkie ładowanie.", "Elektryczny", "/images/cars/porsche-taycan.jpg", true, "Taycan 4S", 571, 899m, "512 KM", 4.9000000000000004, 21, 4, "Automat", 2024 },
                    { 23, "Bestseller", "Volkswagen", "Kompaktowe", "Sportowy kompakt idealny do codziennej jazdy, oferujący dynamiczne prowadzenie i praktyczne wnętrze.", "Benzyna", "/images/cars/vw-golf-gti.jpg", true, "Golf GTI", 265, 399m, "450 KM", 4.7000000000000002, 35, 5, "Automat", 2024 },
                    { 24, null, "Audi", "Kompaktowe", "Elegancki kompakt Audi łączący komfort, nowoczesne technologie i ekonomiczną jazdę.", "Benzyna", "/images/cars/audi-a3.jpg", true, "A3", 150, 349m, "500 KM", 4.5999999999999996, 29, 5, "Automat", 2024 },
                    { 25, null, "BMW", "Kompaktowe", "Kompaktowe BMW oferujące dynamiczną jazdę, komfortowe wnętrze i sportowy charakter.", "Benzyna", "/images/cars/bmw-1.jpg", true, "120i", 178, 369m, "480 KM", 4.5999999999999996, 20, 5, "Automat", 2024 },
                    { 26, "Eco", "Toyota", "Sedan", "Komfortowy sedan hybrydowy zapewniający niskie zużycie paliwa i wygodę podczas długich podróży.", "Hybryda", "/images/cars/toyota-camry.jpg", true, "Camry", 218, 299m, "800 KM", 4.5999999999999996, 31, 5, "Automat", 2024 },
                    { 27, "Eco", "Toyota", "SUV", "Wszechstronny SUV hybrydowy oferujący przestronne wnętrze, komfort i ekonomiczną jazdę.", "Hybryda", "/images/cars/toyota-rav4.jpg", true, "RAV4", 222, 349m, "750 KM", 4.7000000000000002, 38, 5, "Automat", 2024 },
                    { 28, null, "Volvo", "SUV", "Elegancki SUV Volvo zapewniający wysoki komfort, bezpieczeństwo i nowoczesny napęd hybrydowy.", "Hybryda", "/images/cars/volvo-xc60.jpg", true, "XC60", 455, 549m, "700 KM", 4.7999999999999998, 27, 5, "Automat", 2024 },
                    { 29, "Premium", "Volvo", "SUV", "Duży SUV premium z przestronnym wnętrzem, siedmioma miejscami i wysokim komfortem podróżowania.", "Hybryda", "/images/cars/volvo-xc90.jpg", true, "XC90", 455, 649m, "700 KM", 4.7999999999999998, 24, 7, "Automat", 2024 },
                    { 30, "Ikona", "Ford", "Sportowe", "Klasyczny amerykański muscle car oferujący mocny silnik, charakterystyczny wygląd i sportowe emocje.", "Benzyna", "/images/cars/ford-mustang.jpg", true, "Mustang GT", 480, 699m, "500 KM", 4.7999999999999998, 39, 4, "Automat", 2024 },
                    { 31, null, "Ford", "SUV", "Przestronny SUV idealny dla większej grupy pasażerów, oferujący siedem miejsc i wysoki komfort.", "Benzyna", "/images/cars/ford-explorer.jpg", true, "Explorer", 300, 449m, "600 KM", 4.5999999999999996, 19, 7, "Automat", 2024 },
                    { 32, "Premium", "Range Rover", "SUV", "Luksusowy SUV oferujący doskonały komfort, wysoką jakość wykonania i możliwości na długie trasy.", "Diesel", "/images/cars/range-rover-sport.jpg", true, "Sport", 300, 999m, "700 KM", 4.9000000000000004, 23, 5, "Automat", 2024 },
                    { 33, "Hot", "Land Rover", "SUV", "Wszechstronny SUV terenowy łączący luksusowe wnętrze z doskonałymi możliwościami poza asfaltem.", "Diesel", "/images/cars/defender.jpg", true, "Defender", 300, 699m, "750 KM", 4.7999999999999998, 30, 5, "Automat", 2024 },
                    { 34, "Eco", "Lexus", "Premium", "Luksusowy SUV hybrydowy oferujący komfort, nowoczesne technologie i wyjątkową stylistykę.", "Hybryda", "/images/cars/lexus-rx.jpg", true, "RX 500h", 371, 599m, "650 KM", 4.7999999999999998, 22, 5, "Automat", 2024 },
                    { 35, "Ikona", "Lexus", "Sportowe", "Ekskluzywne coupe stworzone dla kierowców ceniących wyjątkowy design, komfort i mocny silnik.", "Benzyna", "/images/cars/lexus-lc500.jpg", true, "LC 500", 477, 999m, "500 KM", 4.9000000000000004, 16, 4, "Automat", 2023 },
                    { 36, null, "Alfa Romeo", "Sportowe", "Sportowy sedan Alfa Romeo oferujący charakterystyczne włoskie wzornictwo i wyjątkową dynamikę.", "Benzyna", "/images/cars/alfa-giulia.jpg", true, "Giulia Quadrifoglio", 520, 799m, "500 KM", 4.7999999999999998, 17, 5, "Automat", 2023 },
                    { 37, "Nowy", "Cupra", "SUV", "Sportowy crossover łączący praktyczność SUV-a z dynamicznym prowadzeniem i nowoczesnym wyglądem.", "Benzyna", "/images/cars/cupra-formentor.jpg", true, "Formentor VZ", 310, 449m, "500 KM", 4.7000000000000002, 26, 5, "Automat", 2024 },
                    { 38, null, "Skoda", "Sedan", "Przestronny i komfortowy sedan idealny zarówno do miasta, jak i długich podróży.", "Diesel", "/images/cars/skoda-superb.jpg", true, "Superb", 193, 299m, "850 KM", 4.5999999999999996, 44, 5, "Automat", 2024 },
                    { 39, null, "Volkswagen", "SUV", "Nowoczesny SUV Volkswagena oferujący praktyczne wnętrze, komfort i wszechstronność.", "Benzyna", "/images/cars/vw-tiguan.jpg", true, "Tiguan", 190, 329m, "600 KM", 4.5999999999999996, 33, 5, "Automat", 2024 },
                    { 40, null, "Audi", "SUV", "Elegancki SUV Audi zapewniający komfortową jazdę, przestronne wnętrze i wysoką jakość wykonania.", "Diesel", "/images/cars/audi-q5.jpg", true, "Q5", 204, 449m, "750 KM", 4.7000000000000002, 29, 5, "Automat", 2024 },
                    { 41, null, "BMW", "SUV", "Wszechstronny SUV BMW łączący komfort, dynamiczne prowadzenie i praktyczne wnętrze.", "Benzyna", "/images/cars/bmw-x3.jpg", true, "X3", 245, 449m, "600 KM", 4.7000000000000002, 32, 5, "Automat", 2024 },
                    { 42, null, "Mercedes-Benz", "SUV", "Nowoczesny SUV Mercedes-Benz oferujący luksusowe wnętrze, komfort i wysoką kulturę jazdy.", "Benzyna", "/images/cars/mercedes-glc.jpg", true, "GLC", 258, 499m, "600 KM", 4.7999999999999998, 28, 5, "Automat", 2024 },
                    { 43, "Eco", "Tesla", "Elektryczne", "Praktyczny SUV elektryczny oferujący duży zasięg, przestronne wnętrze i nowoczesne technologie.", "Elektryczny", "/images/cars/tesla-model-y.jpg", true, "Model Y", 455, 549m, "533 KM", 4.7000000000000002, 51, 5, "Automat", 2024 },
                    { 44, "Eco", "Mercedes-Benz", "Elektryczne", "Luksusowy sedan elektryczny oferujący wysoki komfort, duży zasięg i nowoczesne rozwiązania.", "Elektryczny", "/images/cars/mercedes-eqe.jpg", true, "EQE", 408, 699m, "590 KM", 4.7999999999999998, 20, 5, "Automat", 2024 },
                    { 45, "Eco", "Audi", "Elektryczne", "Elektryczny SUV Audi zapewniający komfortową jazdę, przestronne wnętrze i nowoczesny napęd.", "Elektryczny", "/images/cars/audi-q8-etron.jpg", true, "Q8 e-tron", 408, 649m, "582 KM", 4.7000000000000002, 18, 5, "Automat", 2024 },
                    { 46, "Ikona", "Nissan", "Sportowe", "Legendarny sportowy samochód Nissana oferujący ogromną moc i wyjątkowe osiągi.", "Benzyna", "/images/cars/nissan-gtr.jpg", true, "GT-R", 570, 1199m, "500 KM", 4.9000000000000004, 35, 4, "Automat", 2023 },
                    { 47, "Hot", "Toyota", "Sportowe", "Nowoczesne sportowe coupe Toyoty oferujące świetne prowadzenie, dynamiczny silnik i charakter.", "Benzyna", "/images/cars/toyota-supra.jpg", true, "GR Supra", 340, 649m, "450 KM", 4.7999999999999998, 28, 2, "Automat", 2024 },
                    { 48, null, "Mazda", "Sportowe", "Lekki roadster zapewniający wyjątkową przyjemność z jazdy, szczególnie na krętych drogach.", "Benzyna", "/images/cars/mazda-mx5.jpg", true, "MX-5", 184, 299m, "450 KM", 4.7000000000000002, 37, 2, "Manual", 2024 },
                    { 49, "Eco", "Renault", "Elektryczne", "Kompaktowy samochód elektryczny oferujący nowoczesne wnętrze, dobry zasięg i komfortową jazdę.", "Elektryczny", "/images/cars/renault-megane.jpg", true, "Megane E-Tech", 220, 329m, "450 KM", 4.5999999999999996, 19, 5, "Automat", 2024 },
                    { 50, "Nowy", "Mini", "Kompaktowe", "Stylowy kompakt oferujący dynamiczną jazdę, charakterystyczny design i komfort na co dzień.", "Benzyna", "/images/cars/mini-cooper.jpg", true, "Cooper S", 204, 299m, "450 KM", 4.5999999999999996, 23, 4, "Automat", 2024 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "Badge",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Range",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ReviewsCount",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Seats",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Cars");
        }
    }
}
