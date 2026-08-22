import { Component, input } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import {
  faUser,
  faGasPump,
  faGauge
} from '@fortawesome/free-solid-svg-icons';

import { Car } from '../../models/car';

@Component({
  selector: 'app-car-card',
  imports: [FontAwesomeModule],
  templateUrl: './car-card.html',
  styleUrl: './car-card.css',
})
export class CarCard {

  car = input.required<Car>();

  faUser = faUser;
  faGasPump = faGasPump;
  faGauge = faGauge;

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
}
