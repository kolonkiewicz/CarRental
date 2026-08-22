import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import {
  faXmark
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-auth-navbar',
  imports: [FontAwesomeModule],
  templateUrl: './auth-navbar.html',
  styleUrl: './auth-navbar.css',
})
export class AuthNavbar {
  faXmark = faXmark;

  constructor(private router: Router){}

  onHome(): void{
    this.router.navigate(['/']);
  }

  onClose(): void{
    this.router.navigate(['/']);
  }
}
