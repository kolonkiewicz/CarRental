using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Api.Data;

public static class CarSeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(

            // =========================
            // SPORTOWE
            // =========================

            new Car
            {
                CarId = 1,
                Brand = "Porsche",
                Model = "911 GT3",
                Category = "Sportowe",
                Description = "Wyjątkowe sportowe coupe stworzone z myślą o maksymalnych osiągach i precyzyjnym prowadzeniu.",
                ImageUrl = "/images/cars/porsche-911-gt3.jpg",
                Year = 2024,
                Seats = 2,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 510,
                Range = "450 KM",
                PricePerDay = 1499,
                Rating = 4.9,
                ReviewsCount = 32,
                IsAvailable = true,
                IsFeatured = true,
                Badge = "Bestseller"
            },

            new Car
            {
                CarId = 2,
                Brand = "Porsche",
                Model = "718 Cayman",
                Category = "Sportowe",
                Description = "Lekki i dynamiczny samochód sportowy oferujący świetne prowadzenie oraz wyjątkowe wrażenia z jazdy.",
                ImageUrl = "/images/cars/porsche-718-cayman.jpg",
                Year = 2024,
                Seats = 2,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 300,
                Range = "350 KM",
                PricePerDay = 899,
                Rating = 4.8,
                ReviewsCount = 24,
                IsAvailable = true,
                IsFeatured = true,
                Badge = null
            },

            new Car
            {
                CarId = 3,
                Brand = "BMW",
                Model = "M4 Competition",
                Category = "Sportowe",
                Description = "Sportowy sedan łączący wysoką moc, agresywną stylistykę i komfort podczas codziennej jazdy.",
                ImageUrl = "/images/cars/bmw-m4.jpg",
                Year = 2024,
                Seats = 4,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 510,
                Range = "450 KM",
                PricePerDay = 999,
                Rating = 4.8,
                ReviewsCount = 29,
                IsAvailable = true,
                Badge = "Hot"
            },

            new Car
            {
                CarId = 4,
                Brand = "Mercedes-AMG",
                Model = "GT",
                Category = "Sportowe",
                Description = "Luksusowe coupe AMG oferujące imponujące osiągi, komfort i charakterystyczny sportowy charakter.",
                ImageUrl = "/images/cars/mercedes-amg-gt.jpg",
                Year = 2024,
                Seats = 2,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 585,
                Range = "500 KM",
                PricePerDay = 1399,
                Rating = 4.9,
                ReviewsCount = 18,
                IsAvailable = true,
                Badge = "Premium"
            },

            new Car
            {
                CarId = 5,
                Brand = "Audi",
                Model = "R8 V10",
                Category = "Sportowe",
                Description = "Legendarny supersamochód z silnikiem V10, który zapewnia wyjątkowe osiągi i niezapomniane emocje.",
                ImageUrl = "/images/cars/audi-r8.jpg",
                Year = 2023,
                Seats = 2,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 620,
                Range = "580 KM",
                PricePerDay = 1599,
                Rating = 4.9,
                ReviewsCount = 41,
                IsAvailable = true,
                Badge = "Ikona"
            },

            // =========================
            // SEDANY
            // =========================

            new Car
            {
                CarId = 6,
                Brand = "BMW",
                Model = "M5 Competition",
                Category = "Sedan",
                Description = "Mocny i komfortowy sedan klasy premium idealny zarówno na długie trasy, jak i dynamiczną jazdę.",
                ImageUrl = "/images/cars/bmw-m5.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 625,
                Range = "625 KM",
                PricePerDay = 999,
                Rating = 4.8,
                ReviewsCount = 37,
                IsAvailable = true,
                Badge = "Nowy"
            },

            new Car
            {
                CarId = 7,
                Brand = "Mercedes-Benz",
                Model = "E53 AMG",
                Category = "Sedan",
                Description = "Elegancki sedan AMG łączący sportowe osiągi z wysokim komfortem i nowoczesnymi technologiami.",
                ImageUrl = "/images/cars/mercedes-e53.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 435,
                Range = "450 KM",
                PricePerDay = 849,
                Rating = 4.7,
                ReviewsCount = 21,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 8,
                Brand = "Audi",
                Model = "RS6",
                Category = "Sedan",
                Description = "Przestronne i niezwykle szybkie auto klasy premium oferujące połączenie praktyczności i osiągów.",
                ImageUrl = "/images/cars/audi-rs6.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 600,
                Range = "550 KM",
                PricePerDay = 1099,
                Rating = 4.9,
                ReviewsCount = 34,
                IsAvailable = true,
                IsFeatured = true,
                Badge = "Bestseller"
            },

            new Car
            {
                CarId = 9,
                Brand = "BMW",
                Model = "M3",
                Category = "Sedan",
                Description = "Dynamiczny sedan BMW oferujący sportowe prowadzenie, wysoką moc i komfort na co dzień.",
                ImageUrl = "/images/cars/bmw-m3.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 510,
                Range = "450 KM",
                PricePerDay = 899,
                Rating = 4.8,
                ReviewsCount = 27,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 10,
                Brand = "Mercedes-Benz",
                Model = "S580",
                Category = "Sedan",
                Description = "Luksusowy sedan zapewniający wyjątkowy komfort jazdy, przestronne wnętrze i mocny silnik.",
                ImageUrl = "/images/cars/mercedes-s580.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 503,
                Range = "500 KM",
                PricePerDay = 1299,
                Rating = 4.9,
                ReviewsCount = 19,
                IsAvailable = true,
                Badge = "Premium"
            },

            // =========================
            // SUV
            // =========================

            new Car
            {
                CarId = 11,
                Brand = "Mercedes-AMG",
                Model = "G63",
                Category = "SUV",
                Description = "Ikoniczny SUV AMG łączący luksus, terenowy charakter i imponujące osiągi.",
                ImageUrl = "/images/cars/g63.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 585,
                Range = "585 KM",
                PricePerDay = 1299,
                Rating = 4.9,
                ReviewsCount = 45,
                IsAvailable = true,
                IsFeatured = true,
                Badge = "Premium"
            },

            new Car
            {
                CarId = 12,
                Brand = "BMW",
                Model = "X5 M Competition",
                Category = "SUV",
                Description = "Potężny SUV BMW oferujący sportowe osiągi, przestronne wnętrze i wysoki komfort podróżowania.",
                ImageUrl = "/images/cars/bmw-x5m.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 625,
                Range = "550 KM",
                PricePerDay = 1099,
                Rating = 4.8,
                ReviewsCount = 31,
                IsAvailable = true,
                IsFeatured = true,
                Badge = "Hot"
            },

            new Car
            {
                CarId = 13,
                Brand = "Porsche",
                Model = "Cayenne",
                Category = "SUV",
                Description = "Luksusowy SUV Porsche zapewniający doskonałe prowadzenie, komfort oraz wszechstronność.",
                ImageUrl = "/images/cars/porsche-cayenne.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 353,
                Range = "400 KM",
                PricePerDay = 899,
                Rating = 4.8,
                ReviewsCount = 28,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 14,
                Brand = "Audi",
                Model = "RS Q8",
                Category = "SUV",
                Description = "Sportowy SUV Audi łączący potężny silnik, luksusowe wnętrze i wyjątkową dynamikę.",
                ImageUrl = "/images/cars/audi-rsq8.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 600,
                Range = "550 KM",
                PricePerDay = 1199,
                Rating = 4.9,
                ReviewsCount = 26,
                IsAvailable = true,
                Badge = "Bestseller"
            },

            new Car
            {
                CarId = 15,
                Brand = "Lamborghini",
                Model = "Urus",
                Category = "SUV",
                Description = "Luksusowy supersuv Lamborghini oferujący ekstremalne osiągi i wyjątkowy charakter.",
                ImageUrl = "/images/cars/lamborghini-urus.jpg",
                Year = 2023,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 666,
                Range = "650 KM",
                PricePerDay = 1999,
                Rating = 5.0,
                ReviewsCount = 17,
                IsAvailable = true,
                Badge = "Ikona"
            },

            // =========================
            // PREMIUM
            // =========================

            new Car
            {
                CarId = 16,
                Brand = "BMW",
                Model = "7 Series",
                Category = "Premium",
                Description = "Luksusowa limuzyna BMW zapewniająca najwyższy komfort, nowoczesne technologie i dużą moc.",
                ImageUrl = "/images/cars/bmw-7.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Hybryda",
                Transmission = "Automat",
                Power = 571,
                Range = "500 KM",
                PricePerDay = 999,
                Rating = 4.9,
                ReviewsCount = 22,
                IsAvailable = true,
                Badge = "Premium"
            },

            new Car
            {
                CarId = 17,
                Brand = "Mercedes-Benz",
                Model = "S-Class",
                Category = "Premium",
                Description = "Flagowy sedan Mercedesa stworzony z myślą o najwyższym poziomie komfortu i elegancji.",
                ImageUrl = "/images/cars/mercedes-s-class.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 435,
                Range = "500 KM",
                PricePerDay = 1099,
                Rating = 4.9,
                ReviewsCount = 25,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 18,
                Brand = "Audi",
                Model = "A8",
                Category = "Premium",
                Description = "Elegancka limuzyna Audi oferująca komfortowe wnętrze, nowoczesne technologie i spokojną jazdę.",
                ImageUrl = "/images/cars/audi-a8.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Diesel",
                Transmission = "Automat",
                Power = 286,
                Range = "700 KM",
                PricePerDay = 799,
                Rating = 4.7,
                ReviewsCount = 18,
                IsAvailable = true,
                Badge = null
            },

            // =========================
            // ELEKTRYCZNE
            // =========================

            new Car
            {
                CarId = 19,
                Brand = "Tesla",
                Model = "Model S",
                Category = "Elektryczne",
                Description = "Elektryczny sedan o imponujących osiągach i dużym zasięgu, idealny na długie podróże.",
                ImageUrl = "/images/cars/tesla-model-s.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 670,
                Range = "634 KM",
                PricePerDay = 899,
                Rating = 4.8,
                ReviewsCount = 36,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 20,
                Brand = "Tesla",
                Model = "Model 3",
                Category = "Elektryczne",
                Description = "Popularny elektryczny sedan oferujący świetny zasięg, dynamiczną jazdę i nowoczesne technologie.",
                ImageUrl = "/images/cars/tesla-model-3.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 513,
                Range = "629 KM",
                PricePerDay = 499,
                Rating = 4.7,
                ReviewsCount = 42,
                IsAvailable = true,
                IsFeatured = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 21,
                Brand = "BMW",
                Model = "i4 M50",
                Category = "Elektryczne",
                Description = "Sportowy samochód elektryczny BMW łączący dynamiczne osiągi z komfortem codziennego użytkowania.",
                ImageUrl = "/images/cars/bmw-i4.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 544,
                Range = "510 KM",
                PricePerDay = 699,
                Rating = 4.8,
                ReviewsCount = 23,
                IsAvailable = true,
                IsFeatured = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 22,
                Brand = "Porsche",
                Model = "Taycan 4S",
                Category = "Elektryczne",
                Description = "Elektryczne Porsche oferujące sportowe osiągi, luksusowe wnętrze i szybkie ładowanie.",
                ImageUrl = "/images/cars/porsche-taycan.jpg",
                Year = 2024,
                Seats = 4,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 571,
                Range = "512 KM",
                PricePerDay = 899,
                Rating = 4.9,
                ReviewsCount = 21,
                IsAvailable = true,
                Badge = "Premium"
            },

            // =========================
            // KOMPAKTOWE
            // =========================

            new Car
            {
                CarId = 23,
                Brand = "Volkswagen",
                Model = "Golf GTI",
                Category = "Kompaktowe",
                Description = "Sportowy kompakt idealny do codziennej jazdy, oferujący dynamiczne prowadzenie i praktyczne wnętrze.",
                ImageUrl = "/images/cars/vw-golf-gti.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 265,
                Range = "450 KM",
                PricePerDay = 399,
                Rating = 4.7,
                ReviewsCount = 35,
                IsAvailable = true,
                Badge = "Bestseller"
            },

            new Car
            {
                CarId = 24,
                Brand = "Audi",
                Model = "A3",
                Category = "Kompaktowe",
                Description = "Elegancki kompakt Audi łączący komfort, nowoczesne technologie i ekonomiczną jazdę.",
                ImageUrl = "/images/cars/audi-a3.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 150,
                Range = "500 KM",
                PricePerDay = 349,
                Rating = 4.6,
                ReviewsCount = 29,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 25,
                Brand = "BMW",
                Model = "120i",
                Category = "Kompaktowe",
                Description = "Kompaktowe BMW oferujące dynamiczną jazdę, komfortowe wnętrze i sportowy charakter.",
                ImageUrl = "/images/cars/bmw-1.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 178,
                Range = "480 KM",
                PricePerDay = 369,
                Rating = 4.6,
                ReviewsCount = 20,
                IsAvailable = true,
                Badge = null
            },

            // =========================
            // DALSZA FLOTA
            // =========================

            new Car
            {
                CarId = 26,
                Brand = "Toyota",
                Model = "Camry",
                Category = "Sedan",
                Description = "Komfortowy sedan hybrydowy zapewniający niskie zużycie paliwa i wygodę podczas długich podróży.",
                ImageUrl = "/images/cars/toyota-camry.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Hybryda",
                Transmission = "Automat",
                Power = 218,
                Range = "800 KM",
                PricePerDay = 299,
                Rating = 4.6,
                ReviewsCount = 31,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 27,
                Brand = "Toyota",
                Model = "RAV4",
                Category = "SUV",
                Description = "Wszechstronny SUV hybrydowy oferujący przestronne wnętrze, komfort i ekonomiczną jazdę.",
                ImageUrl = "/images/cars/toyota-rav4.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Hybryda",
                Transmission = "Automat",
                Power = 222,
                Range = "750 KM",
                PricePerDay = 349,
                Rating = 4.7,
                ReviewsCount = 38,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 28,
                Brand = "Volvo",
                Model = "XC60",
                Category = "SUV",
                Description = "Elegancki SUV Volvo zapewniający wysoki komfort, bezpieczeństwo i nowoczesny napęd hybrydowy.",
                ImageUrl = "/images/cars/volvo-xc60.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Hybryda",
                Transmission = "Automat",
                Power = 455,
                Range = "700 KM",
                PricePerDay = 549,
                Rating = 4.8,
                ReviewsCount = 27,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 29,
                Brand = "Volvo",
                Model = "XC90",
                Category = "SUV",
                Description = "Duży SUV premium z przestronnym wnętrzem, siedmioma miejscami i wysokim komfortem podróżowania.",
                ImageUrl = "/images/cars/volvo-xc90.jpg",
                Year = 2024,
                Seats = 7,
                FuelType = "Hybryda",
                Transmission = "Automat",
                Power = 455,
                Range = "700 KM",
                PricePerDay = 649,
                Rating = 4.8,
                ReviewsCount = 24,
                IsAvailable = true,
                Badge = "Premium"
            },

            new Car
            {
                CarId = 30,
                Brand = "Ford",
                Model = "Mustang GT",
                Category = "Sportowe",
                Description = "Klasyczny amerykański muscle car oferujący mocny silnik, charakterystyczny wygląd i sportowe emocje.",
                ImageUrl = "/images/cars/ford-mustang.jpg",
                Year = 2024,
                Seats = 4,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 480,
                Range = "500 KM",
                PricePerDay = 699,
                Rating = 4.8,
                ReviewsCount = 39,
                IsAvailable = true,
                Badge = "Ikona"
            },

            new Car
            {
                CarId = 31,
                Brand = "Ford",
                Model = "Explorer",
                Category = "SUV",
                Description = "Przestronny SUV idealny dla większej grupy pasażerów, oferujący siedem miejsc i wysoki komfort.",
                ImageUrl = "/images/cars/ford-explorer.jpg",
                Year = 2024,
                Seats = 7,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 300,
                Range = "600 KM",
                PricePerDay = 449,
                Rating = 4.6,
                ReviewsCount = 19,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 32,
                Brand = "Range Rover",
                Model = "Sport",
                Category = "SUV",
                Description = "Luksusowy SUV oferujący doskonały komfort, wysoką jakość wykonania i możliwości na długie trasy.",
                ImageUrl = "/images/cars/range-rover-sport.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Diesel",
                Transmission = "Automat",
                Power = 300,
                Range = "700 KM",
                PricePerDay = 999,
                Rating = 4.9,
                ReviewsCount = 23,
                IsAvailable = true,
                Badge = "Premium"
            },

            new Car
            {
                CarId = 33,
                Brand = "Land Rover",
                Model = "Defender",
                Category = "SUV",
                Description = "Wszechstronny SUV terenowy łączący luksusowe wnętrze z doskonałymi możliwościami poza asfaltem.",
                ImageUrl = "/images/cars/defender.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Diesel",
                Transmission = "Automat",
                Power = 300,
                Range = "750 KM",
                PricePerDay = 699,
                Rating = 4.8,
                ReviewsCount = 30,
                IsAvailable = true,
                Badge = "Hot"
            },

            new Car
            {
                CarId = 34,
                Brand = "Lexus",
                Model = "RX 500h",
                Category = "Premium",
                Description = "Luksusowy SUV hybrydowy oferujący komfort, nowoczesne technologie i wyjątkową stylistykę.",
                ImageUrl = "/images/cars/lexus-rx.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Hybryda",
                Transmission = "Automat",
                Power = 371,
                Range = "650 KM",
                PricePerDay = 599,
                Rating = 4.8,
                ReviewsCount = 22,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 35,
                Brand = "Lexus",
                Model = "LC 500",
                Category = "Sportowe",
                Description = "Ekskluzywne coupe stworzone dla kierowców ceniących wyjątkowy design, komfort i mocny silnik.",
                ImageUrl = "/images/cars/lexus-lc500.jpg",
                Year = 2023,
                Seats = 4,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 477,
                Range = "500 KM",
                PricePerDay = 999,
                Rating = 4.9,
                ReviewsCount = 16,
                IsAvailable = true,
                Badge = "Ikona"
            },

            new Car
            {
                CarId = 36,
                Brand = "Alfa Romeo",
                Model = "Giulia Quadrifoglio",
                Category = "Sportowe",
                Description = "Sportowy sedan Alfa Romeo oferujący charakterystyczne włoskie wzornictwo i wyjątkową dynamikę.",
                ImageUrl = "/images/cars/alfa-giulia.jpg",
                Year = 2023,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 520,
                Range = "500 KM",
                PricePerDay = 799,
                Rating = 4.8,
                ReviewsCount = 17,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 37,
                Brand = "Cupra",
                Model = "Formentor VZ",
                Category = "SUV",
                Description = "Sportowy crossover łączący praktyczność SUV-a z dynamicznym prowadzeniem i nowoczesnym wyglądem.",
                ImageUrl = "/images/cars/cupra-formentor.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 310,
                Range = "500 KM",
                PricePerDay = 449,
                Rating = 4.7,
                ReviewsCount = 26,
                IsAvailable = true,
                Badge = "Nowy"
            },

            new Car
            {
                CarId = 38,
                Brand = "Skoda",
                Model = "Superb",
                Category = "Sedan",
                Description = "Przestronny i komfortowy sedan idealny zarówno do miasta, jak i długich podróży.",
                ImageUrl = "/images/cars/skoda-superb.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Diesel",
                Transmission = "Automat",
                Power = 193,
                Range = "850 KM",
                PricePerDay = 299,
                Rating = 4.6,
                ReviewsCount = 44,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 39,
                Brand = "Volkswagen",
                Model = "Tiguan",
                Category = "SUV",
                Description = "Nowoczesny SUV Volkswagena oferujący praktyczne wnętrze, komfort i wszechstronność.",
                ImageUrl = "/images/cars/vw-tiguan.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 190,
                Range = "600 KM",
                PricePerDay = 329,
                Rating = 4.6,
                ReviewsCount = 33,
                IsAvailable = true,
                IsFeatured = true,
                Badge = null
            },

            new Car
            {
                CarId = 40,
                Brand = "Audi",
                Model = "Q5",
                Category = "SUV",
                Description = "Elegancki SUV Audi zapewniający komfortową jazdę, przestronne wnętrze i wysoką jakość wykonania.",
                ImageUrl = "/images/cars/audi-q5.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Diesel",
                Transmission = "Automat",
                Power = 204,
                Range = "750 KM",
                PricePerDay = 449,
                Rating = 4.7,
                ReviewsCount = 29,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 41,
                Brand = "BMW",
                Model = "X3",
                Category = "SUV",
                Description = "Wszechstronny SUV BMW łączący komfort, dynamiczne prowadzenie i praktyczne wnętrze.",
                ImageUrl = "/images/cars/bmw-x3.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 245,
                Range = "600 KM",
                PricePerDay = 449,
                Rating = 4.7,
                ReviewsCount = 32,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 42,
                Brand = "Mercedes-Benz",
                Model = "GLC",
                Category = "SUV",
                Description = "Nowoczesny SUV Mercedes-Benz oferujący luksusowe wnętrze, komfort i wysoką kulturę jazdy.",
                ImageUrl = "/images/cars/mercedes-glc.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 258,
                Range = "600 KM",
                PricePerDay = 499,
                Rating = 4.8,
                ReviewsCount = 28,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 43,
                Brand = "Tesla",
                Model = "Model Y",
                Category = "Elektryczne",
                Description = "Praktyczny SUV elektryczny oferujący duży zasięg, przestronne wnętrze i nowoczesne technologie.",
                ImageUrl = "/images/cars/tesla-model-y.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 455,
                Range = "533 KM",
                PricePerDay = 549,
                Rating = 4.7,
                ReviewsCount = 51,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 44,
                Brand = "Mercedes-Benz",
                Model = "EQE",
                Category = "Elektryczne",
                Description = "Luksusowy sedan elektryczny oferujący wysoki komfort, duży zasięg i nowoczesne rozwiązania.",
                ImageUrl = "/images/cars/mercedes-eqe.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 408,
                Range = "590 KM",
                PricePerDay = 699,
                Rating = 4.8,
                ReviewsCount = 20,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 45,
                Brand = "Audi",
                Model = "Q8 e-tron",
                Category = "Elektryczne",
                Description = "Elektryczny SUV Audi zapewniający komfortową jazdę, przestronne wnętrze i nowoczesny napęd.",
                ImageUrl = "/images/cars/audi-q8-etron.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 408,
                Range = "582 KM",
                PricePerDay = 649,
                Rating = 4.7,
                ReviewsCount = 18,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 46,
                Brand = "Nissan",
                Model = "GT-R",
                Category = "Sportowe",
                Description = "Legendarny sportowy samochód Nissana oferujący ogromną moc i wyjątkowe osiągi.",
                ImageUrl = "/images/cars/nissan-gtr.jpg",
                Year = 2023,
                Seats = 4,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 570,
                Range = "500 KM",
                PricePerDay = 1199,
                Rating = 4.9,
                ReviewsCount = 35,
                IsAvailable = true,
                Badge = "Ikona"
            },

            new Car
            {
                CarId = 47,
                Brand = "Toyota",
                Model = "GR Supra",
                Category = "Sportowe",
                Description = "Nowoczesne sportowe coupe Toyoty oferujące świetne prowadzenie, dynamiczny silnik i charakter.",
                ImageUrl = "/images/cars/toyota-supra.jpg",
                Year = 2024,
                Seats = 2,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 340,
                Range = "450 KM",
                PricePerDay = 649,
                Rating = 4.8,
                ReviewsCount = 28,
                IsAvailable = true,
                Badge = "Hot"
            },

            new Car
            {
                CarId = 48,
                Brand = "Mazda",
                Model = "MX-5",
                Category = "Sportowe",
                Description = "Lekki roadster zapewniający wyjątkową przyjemność z jazdy, szczególnie na krętych drogach.",
                ImageUrl = "/images/cars/mazda-mx5.jpg",
                Year = 2024,
                Seats = 2,
                FuelType = "Benzyna",
                Transmission = "Manual",
                Power = 184,
                Range = "450 KM",
                PricePerDay = 299,
                Rating = 4.7,
                ReviewsCount = 37,
                IsAvailable = true,
                Badge = null
            },

            new Car
            {
                CarId = 49,
                Brand = "Renault",
                Model = "Megane E-Tech",
                Category = "Elektryczne",
                Description = "Kompaktowy samochód elektryczny oferujący nowoczesne wnętrze, dobry zasięg i komfortową jazdę.",
                ImageUrl = "/images/cars/renault-megane.jpg",
                Year = 2024,
                Seats = 5,
                FuelType = "Elektryczny",
                Transmission = "Automat",
                Power = 220,
                Range = "450 KM",
                PricePerDay = 329,
                Rating = 4.6,
                ReviewsCount = 19,
                IsAvailable = true,
                Badge = "Eco"
            },

            new Car
            {
                CarId = 50,
                Brand = "Mini",
                Model = "Cooper S",
                Category = "Kompaktowe",
                Description = "Stylowy kompakt oferujący dynamiczną jazdę, charakterystyczny design i komfort na co dzień.",
                ImageUrl = "/images/cars/mini-cooper.jpg",
                Year = 2024,
                Seats = 4,
                FuelType = "Benzyna",
                Transmission = "Automat",
                Power = 204,
                Range = "450 KM",
                PricePerDay = 299,
                Rating = 4.6,
                ReviewsCount = 23,
                IsAvailable = true,
                Badge = "Nowy"
            }
        );
    }
}