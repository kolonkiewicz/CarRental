import { Component } from '@angular/core';

@Component({
  selector: 'app-experience',
  imports: [],
  templateUrl: './experience.html',
  styleUrl: './experience.css',
})
export class Experience {
  carInteriorImg = '/images/car-interior.jpg';

  features: string[] = [
    'Dezynfekcja przed każdym odbiorem',
    'Pełny zbiornik paliwa w cenie',
    'Bezpłatny fotelik dla dziecka',
    'GPS w każdym pojeździe',
  ];
}
