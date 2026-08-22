import { Component } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { Car } from '../../models/car';

import{
  faRotateLeft,
  faSearch
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-car-filter',
  imports: [ FontAwesomeModule ],
  templateUrl: './car-filter.html',
  styleUrl: './car-filter.css',
})
export class CarFilter {
  faSearch = faSearch;
  faRotateLeft = faRotateLeft;

  categories = [
    'Wszystkie',
    'SUV',
    'Sedan',
    'Sportowe',
    'Kombi',
    'Elektryczne'
  ];

  fuels = [
    'Wszystkie',
    'Benzyna',
    'Diesel',
    'Elektryczny',
    'Hybryda'
  ];

  transmissions = [
    'Wszystkie',
    'Automat',
    'Manual'
  ];

  seatsOptions = [
    'Wszystkie',
    '2',
    '4',
    '5',
    '7'
  ];

}
