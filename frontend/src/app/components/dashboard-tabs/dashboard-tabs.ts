import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { ReservationCard } from "../reservation-card/reservation-card";
import { UserProfile } from "../user-profile/user-profile";
import { ReservationService } from '../../services/reservation-service';
import { ReservationDto } from '../../dtos/reservation.dto';

type Tab = 'reservations' | 'profile';

@Component({
  selector: 'app-dashboard-tabs',
  imports: [ReservationCard, UserProfile],
  templateUrl: './dashboard-tabs.html',
  styleUrl: './dashboard-tabs.css',
})
export class DashboardTabs implements OnInit{

  activeTab: Tab = 'reservations';

  private reservationService = inject(ReservationService);
  private cdr = inject(ChangeDetectorRef)

  myReservations: ReservationDto[] = [];

  ngOnInit(): void {
    this.reservationService.getReservations().subscribe({
      next: (reservations) => {
        this.myReservations = reservations;
        this.cdr.detectChanges();
        console.log('rezerwacje' + reservations);
      },
      error: (error) =>{
        console.log("bład przy pobieraniu rezerwacji", error);
      }
      
    });
  }

  setTab(tab: Tab): void{
    this.activeTab = tab;
  }
}
