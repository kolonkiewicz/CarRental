import { Component } from '@angular/core';
import { Navbar } from "../../components/navbar/navbar";
import { Footer } from "../../components/footer/footer";
import { DashboardSummary } from "../../components/dashboard-summary/dashboard-summary";
import { DashboardTabs } from "../../components/dashboard-tabs/dashboard-tabs";
import { BreadcrumbsUniversal } from "../../components/breadcrumbs-universal/breadcrumbs-universal";

@Component({
  selector: 'app-user-dashboard',
  imports: [Navbar, Footer, DashboardSummary, DashboardTabs, BreadcrumbsUniversal],
  templateUrl: './user-dashboard.html',
  styleUrl: './user-dashboard.css',
})
export class UserDashboard {}
