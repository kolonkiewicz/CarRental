import { Component } from '@angular/core';

@Component({
  selector: 'app-navbar',
  imports: [],
  templateUrl: './navbar.html',
  styleUrl: './navbar.css',
})
export class Navbar {
  menuOpen: boolean = false;
  menuItems: string[] = ['Flota', 'Lokalizacje', 'Oferty', 'O nas', 'Kontakt'];

  toggleMenu(): void{
    this.menuOpen = !this.menuOpen;
  }
}
