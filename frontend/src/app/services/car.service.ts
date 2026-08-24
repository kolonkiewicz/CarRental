import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Car } from '../models/car';
import { PriceRange } from '../models/price-range';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  private http = inject(HttpClient);

  private apiUrl = 'http://localhost:5264/api/cars';

  getCars(): Observable<Car[]>{
    return this.http.get<Car[]>(this.apiUrl);
  }

  getCategories(): Observable<string[]>{
    return this.http.get<string[]>(`${this.apiUrl}/categories`);
  }

  getPriceRange(): Observable<PriceRange>{
    return this.http.get<PriceRange>(
      `${this.apiUrl}/price-range`
    )
  };

  getFuels(): Observable<string[]>{
    return this.http.get<string[]>(
      `${this.apiUrl}/fuels`
    )
  };

  getTransmission(): Observable<string[]>{
    return this.http.get<string[]>(
      `${this.apiUrl}/transmissions`
    )
  }

  getSeats(): Observable<number[]>{
    return this.http.get<number[]>(
      `${this.apiUrl}/seats`
    )
  }
}
