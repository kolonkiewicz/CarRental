import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { ReservationDto } from '../dtos/reservation.dto';
import { Observable } from 'rxjs';
import { CreateReservationDto } from '../dtos/create-reservation.dto';

@Injectable({
  providedIn: 'root',
})
export class ReservationService {
  private http = inject(HttpClient);

  private apiUrl = 'http://localhost:5264/api/reservations';

  getReservations(): Observable<ReservationDto[]> {
    return this.http.get<ReservationDto[]>(this.apiUrl);
  }

  createReservation(dto: CreateReservationDto): Observable<any> {
    return this.http.post(this.apiUrl, dto);
  } 

  getCarReservations(carId: number): Observable<any[]>{
    return this.http.get<any[]>(`${this.apiUrl}/car/${carId}`);
  }
}
