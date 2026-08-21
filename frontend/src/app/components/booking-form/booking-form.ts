import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-booking-form',
  imports: [FormsModule],
  templateUrl: './booking-form.html',
  styleUrl: './booking-form.css',
})
export class BookingForm {
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
