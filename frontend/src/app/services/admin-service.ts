import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AdminDashboardDto, AdminReservationDto } from '../models/admin-dashboard';
import { AdminUserDto } from '../models/user-admin';
import { CreateCarDto } from '../dtos/create-car.dto';
import { ChangeCarDto } from '../dtos/change-car.dto';

@Injectable({
  providedIn: 'root',
})
export class AdminService {
  private http = inject(HttpClient);

  private apiUrl = 'http://localhost:5264/api/admin/dashboard';

  private apiUrlCars = 'http://localhost:5264/api/cars';

  getDashboard(): Observable<AdminDashboardDto>{
    return this.http.get<AdminDashboardDto>(this.apiUrl);
  }

  getReservations(): Observable<AdminReservationDto[]>{
    return this.http.get<AdminReservationDto[]>(`${this.apiUrl}/reservations`);
  }

  getUsers(): Observable<AdminUserDto[]>{
    return this.http.get<AdminUserDto[]>('http://localhost:5264/api/users');
  }

  createCar(dto: CreateCarDto): Observable<any> {
    return this.http.post(this.apiUrlCars, dto);
  }

  changeCar(id: number, dto: ChangeCarDto): Observable<any>{
    return this.http.put(`${this.apiUrlCars}/${id}`, dto);
  }
}
