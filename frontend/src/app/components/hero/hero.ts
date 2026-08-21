import { Component } from '@angular/core';
import { BookingForm } from '../booking-form/booking-form';

@Component({
  selector: 'app-hero',
  standalone: true,
  imports: [BookingForm],
  templateUrl: './hero.html',
  styleUrl: './hero.css',
})
export class Hero {
  heroImg: string = '/images/porsche-hero.jpg';
}
