import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faChevronRight } from '@fortawesome/free-solid-svg-icons';
import { Router, ActivatedRoute } from '@angular/router';
import { CarService } from '../../services/car.service';
import { NgClass, UpperCasePipe } from '@angular/common';

import { faStar } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-car-detail-header',
  imports: [ FontAwesomeModule, NgClass, UpperCasePipe],
  templateUrl: './car-detail-header.html',
  styleUrl: './car-detail-header.css',
})
export class CarDetailHeader implements OnInit{

  faStar = faStar;

  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);
  private route = inject(ActivatedRoute);

  category = '';
  brand = '';
  model = '';
  rating = 0;
  isAvailable = false;
  reviewsCount = 0;
  badge? = '';
  
    ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.carService.getCarById(id).subscribe({
      next: (car) => {
        this.category = car.category;
        this.brand = car.brand;
        this.model = car.model;
        this.rating = car.rating;
        this.isAvailable = car.isAvailable;
        this.reviewsCount = car.reviewsCount;
        this.badge = car.badge;

        console.log('fdsf:', car);

        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('Bład podczas pobierania samochodu:', error);
      }
    });
  }

  getBadgeClass(badge: string | undefined): string {
    switch (badge) {
      case 'Bestseller':
        return 'badge-bestseller';

      case 'Hot':
        return 'badge-hot';

      case 'Nowy':
        return 'badge-nowy';

      case 'Premium':
        return 'badge-premium';

      case 'Eco':
        return 'badge-eco';

      case 'Ikona':
        return 'badge-ikona';

      default:
        return 'badge-default';
    }
  }

  starsArray = [1, 2, 3, 4, 5];

  mathFloor = Math.floor;

}
