import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { 
  faMagnifyingGlass,
  faTrash
 } from '@fortawesome/free-solid-svg-icons';
import { AdminUserDto } from '../../models/user-admin';
import { AdminService } from '../../services/admin-service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-admin-user',
  imports: [FontAwesomeModule, FormsModule],
  templateUrl: './admin-user.html',
  styleUrl: './admin-user.css',
})
export class AdminUser implements OnInit {
  faMagnifyingGlass = faMagnifyingGlass;
  faTrash = faTrash;

  users: AdminUserDto[] = [];

  private adminService = inject(AdminService);
  private cdr = inject(ChangeDetectorRef);

  searchTerm = '';
  filteredUsers: AdminUserDto[] = [];

  ngOnInit(): void {
    this.adminService.getUsers().subscribe({
      next: (data) => {
        this.users = data;
        this.filteredUsers = data;
        this.cdr.detectChanges();
        console.log("uzytkownicy", data);
      },
      error: (error) =>{
        console.error('blad podczas pobierania uzytkownikow:', error);
      }
    });
  }

  searchUser(): void{
    const search = this.searchTerm.toLowerCase().trim();

    this.filteredUsers = this.users.filter( user =>
      user.surname.toLowerCase().includes(search) ||
      user.email.toLowerCase().includes(search)
    );
  }
}
