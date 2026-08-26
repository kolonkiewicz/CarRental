import { Component } from '@angular/core';
import { ReservationCard } from "../reservation-card/reservation-card";
import { UserProfile } from "../user-profile/user-profile";

type Tab = 'reservations' | 'profile';

@Component({
  selector: 'app-dashboard-tabs',
  imports: [ReservationCard, UserProfile],
  templateUrl: './dashboard-tabs.html',
  styleUrl: './dashboard-tabs.css',
})
export class DashboardTabs {

  activeTab: Tab = 'reservations';

  myReservations = [
    {
      id:1,
      status: 'active'
    },
    {
      id:2,
      status: 'active'
    },
    {
      id:3,
      status: 'completed'
    }
  ];

  setTab(tab: Tab): void{
    this.activeTab = tab;
  }
}
