import { Component, input, output } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { 
  faXmark
 } from '@fortawesome/free-solid-svg-icons';
import { Car } from '../../models/car';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-admin-car-form',
  imports: [FontAwesomeModule, FormsModule, CommonModule],
  templateUrl: './admin-car-form.html',
  styleUrl: './admin-car-form.css',
})
export class AdminCarForm {
  faXmark = faXmark;

  car = input<Car | undefined>();
  close = output<void>();

  get isEditMode(): boolean {
    return this.car() !== undefined;
  }

  formCar: Partial<Car> = {};
  
  ngOnInit(){
    if (this.car()){
      this.formCar = { ...this.car() };
    }
  }

  categories = [
  'Sportowe',
  'Sedan',
  'SUV',
  'Premium',
  'Elektryczne'
];

fuelTypes = [
  'Benzyna',
  'Diesel',
  'Hybryda',
  'Elektryczny'
];

transmissions = [
  'Manual',
  'Automat'
];

badges = [
  'Bestseller',
  'Hot',
  'Premium',
  'Ikona',
  'Nowy',
  'Eco'
];
}
