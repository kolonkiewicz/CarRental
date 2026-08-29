import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { inject } from '@angular/core/primitives/di';
import { LoginDto } from '../dtos/login.dto';
import { Observable } from 'rxjs';
import { LoginResponse } from '../dtos/login-response.dto';
import { RegisterDto } from '../dtos/register.dto';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private http = inject(HttpClient);

  private apiUrl = 'http://localhost:5264/api/auth';

  login(dto: LoginDto): Observable<LoginResponse>{
    return this.http.post<LoginResponse>(
      `${this.apiUrl}/login`,
      dto
    )
  }

  register(dto: RegisterDto): Observable<{ message: string }>{
    return this.http.post<{ message: string }>(
      `${this.apiUrl}/register`,
      dto
    )
  }

  logout(): void{
    localStorage.removeItem('token');
    localStorage.removeItem('user');
  }

  getToken(): string | null {
    return localStorage.getItem('token');
  }

  isLoggedIn(): boolean {
    return this.getToken() !== null;
  }

  getCurrentUser(): User | null {
    const user = localStorage.getItem('user');

    if (!user){
      return null;
    }

    return JSON.parse(user)
  }

  saveLogin(response: LoginResponse): void{
    localStorage.setItem('token', response.token);
    localStorage.setItem('user', JSON.stringify(response.user));
  }
}
