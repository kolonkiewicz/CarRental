import { Component } from '@angular/core';
import { AdminSidebar } from "../../components/admin-sidebar/admin-sidebar";
import { AdminHeader } from "../../components/admin-header/admin-header";
import { RouterOutlet } from '@angular/router';
@Component({
  selector: 'app-admin-dashboard',
  imports: [AdminSidebar, AdminHeader, RouterOutlet],
  templateUrl: './admin-dashboard.html',
  styleUrl: './admin-dashboard.css',
})
export class AdminDashboard {}
