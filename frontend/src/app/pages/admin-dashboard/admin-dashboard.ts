import { Component } from '@angular/core';
import { AdminSidebar } from "../../components/admin-sidebar/admin-sidebar";
import { AdminHeader } from "../../components/admin-header/admin-header";
import { AdminReservation } from "../../components/admin-reservation/admin-reservation";
import { AdminMainPage } from "../../components/admin-main-page/admin-main-page";
import { AdminUser } from '../../components/admin-user/admin-user';
import { AdminFleet } from '../../components/admin-fleet/admin-fleet';

type Tab = 'dashboard' | 'reservations' | 'fleet' | 'user';

@Component({
  selector: 'app-admin-dashboard',
  imports: [AdminSidebar, AdminHeader, AdminReservation, AdminMainPage, AdminUser, AdminFleet],
  templateUrl: './admin-dashboard.html',
  styleUrl: './admin-dashboard.css',
})
export class AdminDashboard {

  activeTab: Tab = 'dashboard';

  setTab(tab: Tab): void{
      this.activeTab = tab;
  }
}
