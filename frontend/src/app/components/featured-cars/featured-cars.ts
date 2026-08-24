import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { FontAwesomeModule, FaIconComponent } from '@fortawesome/angular-fontawesome';
import { CarCard } from '../car-card/car-card';
import { Car } from '../../models/car';

import {
  faArrowRight
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-featured-cars',
  imports: [RouterLink, FaIconComponent, CarCard],
  templateUrl: './featured-cars.html',
  styleUrl: './featured-cars.css',
})
export class FeaturedCars {
  faArrowRight = faArrowRight;
  
  fleet: Car[] = [
    {
      id: 1,
      brand: 'Porsche',
      model: '911 GT3',
      category: 'Sportowe',
      imageUrl: '/images/porsche-gt3.jpg',
      year: 2024,
      seats: 2,
      fuelType: 'Benzyna',
      description: 'dsadasd',
      transmission: 'Automat',
      power: 510,
      range: '450 KM',
      pricePerDay: 1499,
      rating: 4.9,
      reviewsCount: 32,
      isAvailable: true,
      isFeatured: false,
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
      description: 'dsadasd',
      power: 625,
      range: '520 KM',
      pricePerDay: 999,
      rating: 4.8,
      reviewsCount: 24,
      isAvailable: true,
      isFeatured: false,
      badge: 'Nowość'
    },

    {
      id: 3,
      brand: 'Mercedes-AMG',
      model: 'G63',
      category: 'SUV',
      imageUrl: '/images/g63.jpg',
      description: 'dsadasd',
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
      isFeatured: false,
      badge: 'Premium'
    }
  ];
}
