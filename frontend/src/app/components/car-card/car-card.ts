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
}
