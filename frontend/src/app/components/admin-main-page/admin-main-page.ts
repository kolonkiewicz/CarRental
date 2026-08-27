import { ChangeDetectorRef, Component, inject, OnInit, output } from '@angular/core';
import { FaIconComponent } from "@fortawesome/angular-fontawesome";
import { faArrowRight } from '@fortawesome/free-solid-svg-icons';
import { AdminService } from '../../services/admin-service';
import { AdminDashboardDto } from '../../models/admin-dashboard';

@Component({
  selector: 'app-admin-main-page',
  imports: [FaIconComponent],
  templateUrl: './admin-main-page.html',
  styleUrl: './admin-main-page.css',
})
export class AdminMainPage implements OnInit {
  faArrowRight = faArrowRight;

  private adminService = inject(AdminService);
  private cdr = inject(ChangeDetectorRef);

  dashboard?: AdminDashboardDto;

  reservationsTab = output<void>();

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
