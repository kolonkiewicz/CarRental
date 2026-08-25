import { Component } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


import { 
  faPhone
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-help-details-car',
  imports: [FontAwesomeModule],
  templateUrl: './help-details-car.html',
  styleUrl: './help-details-car.css',
})
export class HelpDetailsCar {
  faPhone = faPhone;
}
