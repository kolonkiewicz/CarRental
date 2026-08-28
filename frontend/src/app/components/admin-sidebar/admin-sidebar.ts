import { Component, input, output } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


import { 
  faRightFromBracket,
  faCalendar,
  faGauge,
  faChartBar,
  faUser,
  faBars,
  faXmark,
  faSlash
 } from '@fortawesome/free-solid-svg-icons';
import { RouterLink, RouterLinkActive } from "@angular/router";

type Tab = 'dashboard' | 'reservations' | 'fleet' | 'user';

@Component({
  selector: 'app-admin-sidebar',
  imports: [FontAwesomeModule, RouterLink, RouterLinkActive],
  templateUrl: './admin-sidebar.html',
  styleUrl: './admin-sidebar.css',
})
export class AdminSidebar {
  faRightFromBracket = faRightFromBracket;
  faCalendar = faCalendar;
  faGauge = faGauge;
  faChartBar = faChartBar;
  faUser = faUser;

  faBars = faBars;
  faXmark = faXmark;

  isMobileMenuOpen = false;
}
