import { Component, input } from '@angular/core';

type Tab = 'dashboard' | 'reservations' | 'fleet' | 'user';

@Component({
  selector: 'app-admin-header',
  imports: [],
  templateUrl: './admin-header.html',
  styleUrl: './admin-header.css',
})
export class AdminHeader {
  activeTab = input.required<Tab>();

  pageTitles: Record<Tab, string> = {
    dashboard: 'PULPIT',
    user: 'UŻYTKOWNICY',
    reservations: 'REZERWACJE',
    fleet: 'FLOTA'
  };
}
