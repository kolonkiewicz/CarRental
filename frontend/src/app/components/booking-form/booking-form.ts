import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FontAwesomeModule, FaIconComponent } from '@fortawesome/angular-fontawesome';

import {
  faArrowRight
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-booking-form',
  imports: [FaIconComponent],
  templateUrl: './booking-form.html',
  styleUrl: './booking-form.css',
})

export class BookingForm {
  faArrowRight = faArrowRight;

  constructor(private router: Router){};

  toFleet(): void {
    this.router.navigate(['/fleet']);
  }
}
