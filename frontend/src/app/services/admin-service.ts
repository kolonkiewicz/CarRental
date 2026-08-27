import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AdminDashboardDto } from '../models/admin-dashboard';
import { AdminUserDto } from '../models/user-admin';

@Injectable({
  providedIn: 'root',
})
export class AdminService {
  private http = inject(HttpClient);

  private apiUrl = 'http://localhost:5264/api/admin/dashboard';

  getDashboard(): Observable<AdminDashboardDto>{
    return this.http.get<AdminDashboardDto>(this.apiUrl);
  }

  getUsers(): Observable<AdminUserDto[]>{
    return this.http.get<AdminUserDto[]>('http://localhost:5264/api/users');
  }
}
