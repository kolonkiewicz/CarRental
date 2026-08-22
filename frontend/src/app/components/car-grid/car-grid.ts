import { Component } from '@angular/core';
import { CarCard } from '../car-card/car-card';
import { Car } from '../../models/car';

@Component({
  selector: 'app-car-grid',
  imports: [CarCard],
  templateUrl: './car-grid.html',
  styleUrl: './car-grid.css',
})
export class CarGrid {cars: Car[] = [
      {
      id: 1,
      brand: 'Porsche',
      model: '911 GT3',
      category: 'Sportowe',
      imageUrl: '/images/porsche-gt3.jpg',
      year: 2024,
      seats: 2,
      fuelType: 'Benzyna',
      transmission: 'Automat',
      power: 510,
      range: '450 KM',
      pricePerDay: 1499,
      rating: 4.9,
      reviewsCount: 32,
      isAvailable: true,
      badge: 'Bestseller'
    },
    {
      id: 2,
      brand: 'BMW',
      model: 'M5 Competition',
      category: 'Sedan',
      imageUrl: '/images/bmw-m5.jpg',
      year: 2025,
      seats: 5,
      fuelType: 'Benzyna',
      transmission: 'Automat',
      power: 625,
      range: '520 KM',
      pricePerDay: 999,
      rating: 4.8,
      reviewsCount: 24,
      isAvailable: true,
      badge: 'Nowość'
    },
    {
      id: 3,
      brand: 'Mercedes-AMG',
      model: 'G63',
      category: 'SUV',
      imageUrl: '/images/g63.jpg',
      year: 2024,
      seats: 5,
      fuelType: 'Benzyna',
      transmission: 'Automat',
      power: 585,
      range: '480 KM',
      pricePerDay: 1299,
      rating: 4.9,
      reviewsCount: 18,
      isAvailable: true,
      badge: 'Premium'
    }
  ];
}
