import { Component, inject } from '@angular/core';
import { RouterLink } from "@angular/router";
import { AuthService } from '../../services/auth-service';

@Component({
  selector: 'app-navbar',
  imports: [RouterLink],
  templateUrl: './navbar.html',
  styleUrl: './navbar.css',
})
export class Navbar {
  menuOpen: boolean = false;

  private authService = inject(AuthService)

  menuItems = [
    { label: 'Flota', route: '/fleet' },
    { label: 'Lokalizacje', route: '/' },
    { label: 'Oferty', route: '/' },
    { label: 'O nas', route: '/' },
    { label: 'Kontakt', route: '/' }
  ];

  toggleMenu(): void{
    this.menuOpen = !this.menuOpen;
  }

  get isLoggedIn(): boolean{
    return this.authService.isLoggedIn()
  }

  logout(): void {
    this.authService.logout();
  }
}
