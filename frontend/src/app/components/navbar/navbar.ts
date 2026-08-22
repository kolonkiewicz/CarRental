import { Component } from '@angular/core';
import { RouterLink } from "@angular/router";

@Component({
  selector: 'app-navbar',
  imports: [RouterLink],
  templateUrl: './navbar.html',
  styleUrl: './navbar.css',
})
export class Navbar {
  menuOpen: boolean = false;

  menuItems = [
    { label: 'Flota', route: '/' },
    { label: 'Lokalizacje', route: '/' },
    { label: 'Oferty', route: '/' },
    { label: 'O nas', route: '/' },
    { label: 'Kontakt', route: '/' }
  ];

  toggleMenu(): void{
    this.menuOpen = !this.menuOpen;
  }
}
