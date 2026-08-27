import { ChangeDetectorRef, Component, inject, OnInit, output } from '@angular/core';
import { FaIconComponent } from "@fortawesome/angular-fontawesome";
import { faArrowRight } from '@fortawesome/free-solid-svg-icons';
import { AdminService } from '../../services/admin-service';
import { AdminDashboardDto } from '../../models/admin-dashboard';
import { RouterLink } from "@angular/router";

@Component({
  selector: 'app-admin-main-page',
  imports: [FaIconComponent, RouterLink],
  templateUrl: './admin-main-page.html',
  styleUrl: './admin-main-page.css',
})
export class AdminMainPage implements OnInit {
  faArrowRight = faArrowRight;

  private adminService = inject(AdminService);
  private cdr = inject(ChangeDetectorRef);

  dashboard?: AdminDashboardDto;

  ngOnInit(): void {
    this.adminService.getDashboard().subscribe({
      next: (data) => {
        this.dashboard = data;
        this.cdr.detectChanges();
      },
      error: (error) => {
        console.error('blad podczas pobierania dashboardu:', error);
      }
    });
  }

}
