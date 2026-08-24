import { ChangeDetectorRef, Component, CUSTOM_ELEMENTS_SCHEMA, inject, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { FontAwesomeModule, FaIconComponent } from '@fortawesome/angular-fontawesome';
import { CarCard } from '../car-card/car-card';
import { Car } from '../../models/car';
import { register } from 'swiper/element/bundle';

import {
  faArrowRight
} from '@fortawesome/free-solid-svg-icons';
import { CarService } from '../../services/car.service';
import { Cars } from '../../pages/cars/cars';

register();

@Component({
  selector: 'app-featured-cars',
  imports: [RouterLink, FaIconComponent, CarCard],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  templateUrl: './featured-cars.html',
  styleUrl: './featured-cars.css',
})
export class FeaturedCars implements OnInit {
  faArrowRight = faArrowRight;
  
  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);

  featuredCars: Car[] = [];

  ngOnInit(): void{
    this.carService.getFeaturedCars().subscribe({
      next: (cars) => {
        this.featuredCars = cars;
        console.log('featuredcars', cars);
        this.cdr.detectChanges();
      },
      error: (error) => {
        console.log("Blad podczas pobierania featured cars", error);
      }
    });
  }

  
}
