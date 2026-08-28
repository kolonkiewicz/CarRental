import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { 
  faTrash,
  faMagnifyingGlass
 } from '@fortawesome/free-solid-svg-icons';
import { AdminReservationDto } from '../../models/admin-dashboard';
import { AdminService } from '../../services/admin-service';
import { FormsModule } from '@angular/forms';



@Component({
  selector: 'app-admin-reservation',
  imports: [ FontAwesomeModule, FormsModule ],
  templateUrl: './admin-reservation.html',
  styleUrl: './admin-reservation.css',
})
export class AdminReservation implements OnInit {
  faMagnifyingGlass = faMagnifyingGlass;
  faTrash = faTrash;

  private adminService = inject(AdminService);
  private cdr = inject(ChangeDetectorRef);

  reservations: AdminReservationDto[] = [];

  filteredReservations: AdminReservationDto[] = [];

  searchTerm = '';
  selectedStatus = 'Wszystkie';

  ngOnInit(): void {
    this.adminService.getReservations().subscribe({
      next: (data) => {
        this.reservations = data;
        this.filteredReservations = data;
        this.cdr.detectChanges();
      },
      error: (error) => {
        console.error('blad podczas pobierania reserwacji:', error);
      }
    });
  }

  searchReservation(): void{
    this.filterReservations(); 
  }

  filterByStatus(status: string): void{
    this.selectedStatus = status;
    this.filterReservations();
  }

  filterReservations(): void{
    const search = this.searchTerm.toLowerCase().trim();

    this.filteredReservations = this.reservations.filter( reservation => {
      
      const matchesSearch = 
        reservation.customerName.toLowerCase().includes(search) ||
        reservation.carName.toLowerCase().includes(search);
      
      const matchesStatus =
        this.selectedStatus === 'Wszystkie' ||
        reservation.status === this.selectedStatus;

      return matchesSearch && matchesStatus;
    });
  }

}
