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
      name: 'Porsche 911 GT3',
      badge: 'Bestseller',
      category: 'Sportowe',
      img: '/images/porsche-gt3.jpg',
      seats: 2,
      fuel: 'Benzyna',
      range: '510 KM',
      price: 1499,
    },
    {
      name: 'BMW M5 Competition',
      badge: 'Nowość',
      category: 'Sedan',
      img: '/images/bmw-m5.jpg',
      seats: 5,
      fuel: 'Benzyna',
      range: '625 KM',
      price: 999,
    },
    {
      name: 'Mercedes-AMG G63',
      badge: 'Premium',
      category: 'SUV',
      img: '/images/g63.jpg',
      seats: 5,
      fuel: 'Benzyna',
      range: '585 KM',
      price: 1299,
    },
  ];
}
