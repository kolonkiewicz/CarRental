import { Component } from '@angular/core';
import { DecimalPipe } from '@angular/common';

@Component({
  selector: 'app-reservation-card',
  imports: [DecimalPipe],
  templateUrl: './reservation-card.html',
  styleUrl: './reservation-card.css',
})
export class ReservationCard {
  myReservations = [
    {
      id: 'VD-2026-002',
      carName: 'Tesla Model 3',
      carImg: 'https://images.unsplash.com/photo-1657638004785-8811ca915884?w=400&h=250&fit=crop&auto=format',
      status: 'active',
      total: 2394,
      days: 6,
      pricePerDay: 399,
      pickupDate: '2026-09-01',
      pickupLoc: 'Kraków',
      returnDate: '2026-09-07',
      returnLoc: 'Kraków'
    },
    {
      id: 'VD-2026-006',
      carName: 'Mercedes-Benz C 220d',
      carImg: 'https://images.unsplash.com/photo-1708450021766-ee488791f48e?w=400&h=250&fit=crop&auto=format',
      status: 'active',
      total: 1745,
      days: 5,
      pricePerDay: 349,
      pickupDate: '2026-09-20',
      pickupLoc: 'Poznań',
      returnDate: '2026-09-25',
      returnLoc: 'Warszawa Lotnisko'
    },
    {
      id: 'VD-2026-008',
      carName: 'Mercedes EQS 450+',
      carImg: 'https://images.unsplash.com/photo-1571127236794-81c0bbfe1ce3?w=400&h=250&fit=crop&auto=format',
      status: 'active',
      total: 2796,
      days: 4,
      pricePerDay: 699,
      pickupDate: '2026-10-01',
      pickupLoc: 'Warszawa Lotnisko',
      returnDate: '2026-10-05',
      returnLoc: 'Warszawa Lotnisko'
    }
  ];


  cancelReservation(id: string): void {

    const reservation = this.myReservations.find(
      r => r.id === id
    );

    if (!reservation) {
      return;
    }

    reservation.status = 'completed';
  }
}
