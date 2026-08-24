import { Component } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faChevronRight } from '@fortawesome/free-solid-svg-icons';
import { Router } from '@angular/router';

@Component({
  selector: 'app-car-detail-header',
  imports: [ FontAwesomeModule],
  templateUrl: './car-detail-header.html',
  styleUrl: './car-detail-header.css',
})
export class CarDetailHeader {
  faChevronRight = faChevronRight;

  category = "Sportowe"
  brand = "Porsche"
  model = "gt3"

  constructor(private router: Router){}

  onBack(){
    this.router.navigate(['/fleet']);
  }
}
