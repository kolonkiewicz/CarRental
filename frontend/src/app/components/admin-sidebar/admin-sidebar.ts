import { Component, input, output } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


import { 
  faRightFromBracket,
  faCalendar,
  faGauge,
  faChartBar,
  faUser
 } from '@fortawesome/free-solid-svg-icons';

type Tab = 'dashboard' | 'reservations' | 'fleet' | 'user';

@Component({
  selector: 'app-admin-sidebar',
  imports: [FontAwesomeModule],
  templateUrl: './admin-sidebar.html',
  styleUrl: './admin-sidebar.css',
})
export class AdminSidebar {
  faRightFromBracket = faRightFromBracket;
  faCalendar = faCalendar;
  faGauge = faGauge;
  faChartBar = faChartBar;
  faUser = faUser;

  activeTab = input.required<Tab>();
  tabChanged = output<Tab>();


  setTab(tab: Tab): void{
    this.tabChanged.emit(tab);
  }
}
