import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { FaIconComponent } from '@fortawesome/angular-fontawesome';

import { 
  faCheck, 
  faArrowRight, 
  faUsers, 
  faPhone, 
  faEnvelope, 
  faLock,
   faEye, 
   faEyeSlash } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-auth',
  imports: [FormsModule, FaIconComponent],
  templateUrl: './auth.html',
  styleUrl: './auth.css',
})
export class Auth {
  //login /register
  tab: 'login' | 'register' = 'login';

  submitted = false;

  //login fields
  email = '';
  password = '';
  remember = false;

  //register fields
  firstName = '';
  lastName = '';
  phone = '';
  confirmPassword = '';
  agree = false;

  //password visi
  showPassword = false;
  showConfirm = false;

  // Errors
  errors: {
    firstName?: string;
    lastName?: string;
    phone?: string;
    email?: string;
    password?: string;
    confirmPassword?: string;
    agree?: string;
  } = {};
  
  faCheck = faCheck;
  faArrowRight = faArrowRight; 
  faUsers = faUsers; 
  faPhone = faPhone; 
  faEnvelope = faEnvelope; 
  faLock = faLock; 
  faEye = faEye; 
  faEyeSlash = faEyeSlash;

  constructor(private router: Router){}

  switchTab( tab: 'login' | 'register'): void{
    this.tab = tab;
    this.errors = {};
  }

  togglePassword(): void{
    this.showPassword = !this.showPassword;
  }

  toggleConfirmPassword(): void{
    this.showConfirm = !this.showConfirm;
  }

  get passwordStrength(): number{
    if (!this.password){
      return 0;
    }

    return Math.min(Math.floor(this.password.length / 3), 4);
  }
  
  toggleRemember(): void{
    this.remember = !this.remember;
  }

  toggleAgree(): void{
    this.agree = !this.agree;
  }

  submit(): void{
    this.errors = {};

    if ( this.tab == 'login'){
      this.login();
    }else{
      this.register();
    }
  }

  login(): void{
    if (!this.email){
      this.email = 'Podaj adres e-mail.';
    }

    if (!this.password){
      this.password = 'Podaj hasło.';
    }

    if (Object.keys(this.errors).length > 0){
      return;
    }

    console.log('LOGIN',{
      email: this.email,
      password: this.password,
      remember: this.remember
    });

    this.submitted = true;
  }

  register(): void{
    if (!this.firstName){ 
      this.errors.firstName = 'Podaj imię.'; 
    } 
    
    if (!this.lastName){ 
      this.errors.lastName = 'Podaj nazwisko.'; 
    } 
    
    if (!this.phone){ 
      this.errors.phone = 'Podaj numer telefonu.'; 

    } if (!this.email){
      this.errors.email = 'Podaj adres e-mail.'; 
    } 

    if (!this.password){
      this.errors.password = 'Podaj hasło.';
    } 
    
    if (this.password !== this.confirmPassword){ 
      this.errors.confirmPassword = 'Hasła nie są takie same.'; 
    }
    
    if (!this.agree){
      this.errors.agree = 'Musisz zaakceptować regulamin.'; 
    } 
    
    if (Object.keys(this.errors).length > 0){ 
      return; 
    }
    
    console.log('REGISTER',{
      firstName: 
      this.firstName, 
      lastName: 
      this.lastName,
      phone: this.phone,
      email: this.email,
      password: this.password });

      this.submitted = true;
  }

  goToHome(): void { 
    this.router.navigate(['/']); 
  }

}
