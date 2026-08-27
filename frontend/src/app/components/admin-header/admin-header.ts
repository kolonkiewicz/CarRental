import { Component, inject, input } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { every, filter } from 'rxjs';

@Component({
  selector: 'app-admin-header',
  imports: [],
  templateUrl: './admin-header.html',
  styleUrl: './admin-header.css',
})
export class AdminHeader {
  private router = inject(Router);

  pageTitle = 'Pulpit';

  constructor(){
    this.router.events
      .pipe(
        filter( event => event instanceof NavigationEnd)
      )
      .subscribe((event: NavigationEnd) =>{
        this.setPageTitle(event.urlAfterRedirects);
      });
  }

  private setPageTitle(url: string): void{
    
    if (url.includes('/admin/dashboard')) {
      this.pageTitle = 'Pulpit';
    }
    else if (url.includes('/admin/users')) {
      this.pageTitle = 'Użytkownicy';
    }
    else if (url.includes('/admin/reservations')) {
      this.pageTitle = 'Rezerwacje';
    }
    else if (url.includes('/admin/fleet')) {
      this.pageTitle = 'Flota';
    }
  }

}
