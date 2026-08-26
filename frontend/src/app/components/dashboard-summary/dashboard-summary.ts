import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard-summary',
  imports: [],
  templateUrl: './dashboard-summary.html',
  styleUrl: './dashboard-summary.css',
})
export class DashboardSummary {

  
  profile = {
    firstName: 'Jan'
  };

  user = {
    email: 'jan@gmail.com'
  };

  myReservations = [
    {
      status: 'active'
    },
    {
      status: 'active'
    },
    {
      status: 'completed'
    }
  ];

  get activeReservationsCount(): number {
    return this.myReservations.filter(
      reservation => reservation.status === 'active'
    ).length;
  }

  get completedReservationsCount(): number {
    return this.myReservations.filter(
      reservation => reservation.status === 'completed'
    ).length;
  }

}
