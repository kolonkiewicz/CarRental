import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faChevronRight } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-fleet-header',
  imports: [FontAwesomeModule],
  templateUrl: './fleet-header.html',
  styleUrl: './fleet-header.css',
})
export class FleetHeader {
  faChevronRight = faChevronRight;

  totalCars = 12;
  locationsCount = 6;

  constructor(private router: Router){}

  onNavigateHome(){
    this.router.navigate(['/']);
  }
}
