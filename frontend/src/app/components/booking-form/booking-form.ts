import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FontAwesomeModule, FaIconComponent } from '@fortawesome/angular-fontawesome';

import {
  faCalendar,
  faLocationDot,
  faArrowRight
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-booking-form',
  imports: [FormsModule, FaIconComponent],
  templateUrl: './booking-form.html',
  styleUrl: './booking-form.css',
})

export class BookingForm {
  faCalendar = faCalendar;
  faLocationDot = faLocationDot;
  faArrowRight = faArrowRight;

  locations: string[] = ['Warszawa', 'Kraków', 'Gdańsk', 'Wrocław', 'Poznań', 'Katowice'];
  
  pickupLocation: string = this.locations[0];
  returnLocation: string = this.locations[0];
  pickupDate: string = '';
  returnDate: string = '';

  onSearch(): void {
    console.log('Szukam aut:', {
      pickupLocation: this.pickupLocation,
      returnLocation: this.returnLocation,
      pickupDate: this.pickupDate,
      returnDate: this.returnDate
    });
  }
}
