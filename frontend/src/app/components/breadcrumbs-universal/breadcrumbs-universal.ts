import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faChevronRight } from '@fortawesome/free-solid-svg-icons';
import { filter } from 'rxjs';


@Component({
  selector: 'app-breadcrumbs-universal',
  imports: [ FontAwesomeModule],
  templateUrl: './breadcrumbs-universal.html',
  styleUrl: './breadcrumbs-universal.css',
})
export class BreadcrumbsUniversal implements OnInit {
  faChevronRight = faChevronRight;

  currentPage = '';

  private router = inject(Router);

  ngOnInit(): void {

    const url = this.router.url;

    switch ( url ) {
      case '/user/dashboard':
        this.currentPage = 'Twój profil'
        break;
        
      case '/admin/dashboard':
        this.currentPage = 'Admin Panel';
        break;
      }
  };
  

  goHome(): void{
    this.router.navigate(['/']);
  }
}
