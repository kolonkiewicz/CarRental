import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { ReservationDto } from '../dtos/reservation.dto';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ReservationService {
  private http = inject(HttpClient);

  private apiUrl = 'http://localhost:5264/api/reservations';

  getReservations(): Observable<ReservationDto[]> {
    return this.http.get<ReservationDto[]>(this.apiUrl);
  }

}
