import { Component, input } from '@angular/core';
import { DecimalPipe } from '@angular/common';
import { ReservationDto } from '../../dtos/reservation.dto';

@Component({
  selector: 'app-reservation-card',
  imports: [DecimalPipe],
  templateUrl: './reservation-card.html',
  styleUrl: './reservation-card.css',
})
export class ReservationCard {
  reservations = input.required<ReservationDto[]>();

  getDays(reservation: ReservationDto): number {
    const start = new Date(reservation.startDate);
    const end = new Date(reservation.endDate);

    return Math.round((end.getTime() - start.getTime()) / (1000 * 60 * 60 * 24));
  }

  
}
