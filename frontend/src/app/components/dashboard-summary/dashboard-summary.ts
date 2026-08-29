import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth-service';
import { ReservationDto } from '../../dtos/reservation.dto';
import { ReservationService } from '../../services/reservation-service';

@Component({
  selector: 'app-dashboard-summary',
  imports: [],
  templateUrl: './dashboard-summary.html',
  styleUrl: './dashboard-summary.css',
})
export class DashboardSummary implements OnInit {

  private authService = inject(AuthService);

  private reservationService = inject(ReservationService)

  user = this.authService.getCurrentUser();
  
  private cdr = inject(ChangeDetectorRef);

  myReservations: ReservationDto[] = [];

  ngOnInit(): void {
    this.reservationService.getReservations().subscribe({
      next: (reservations) => {
        this.myReservations = reservations;
        console.log('REZERWACJE:', reservations);

        this.cdr.detectChanges()
      },
      error: (error) => {
        console.error('blad podczas pobierania rezerwacji', error);
      }
    });
  }

  

  get activeReservationsCount(): number {
    return this.myReservations.filter(
      reservation => reservation.status === 'Aktywna'
    ).length;
  }

  get completedReservationsCount(): number {
    return this.myReservations.filter(
      reservation => reservation.status === 'Zakończona'
    ).length;
  }
}
