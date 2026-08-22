import { Component } from '@angular/core';
import { AuthNavbar } from "../../components/auth-navbar/auth-navbar";
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-auth-layout',
  imports: [
    RouterOutlet,
    AuthNavbar],
  templateUrl: './auth-layout.html',
  styleUrl: './auth-layout.css',
})
export class AuthLayout {}
