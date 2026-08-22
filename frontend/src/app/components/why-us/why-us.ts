import { Component } from '@angular/core';
import { FontAwesomeModule, FaIconComponent } from '@fortawesome/angular-fontawesome';

import {
  faShieldHalved,
  faLocationDot,
  faHeadset,
  faCarBurst
} from '@fortawesome/free-solid-svg-icons';

export interface Benefit {
  title: string;
  desc: string;
  icon: any;
}

@Component({
  selector: 'app-why-us',
  imports: [FaIconComponent],
  templateUrl: './why-us.html',
  styleUrl: './why-us.css',
})
export class WhyUs {
  

  benefits: Benefit[] =[
    {
      title: 'Bez kaucji i ukrytych opłat',
      desc: 'Jasne zasady od samego początku. Umowa bez drobnika i przejrzysty cennik wynajmu.',
      icon: faShieldHalved
    },
    {
      title: 'Podstawienie pod drzwi',
      desc: 'Dostarczamy wybrane auto w dowolne miejsce w Polsce - na lotnisko, do domu czy biura.',
      icon: faLocationDot
    },
    {
      title: 'Wsparcie 24/7',
      desc: 'Nasz zespół techniczny jest do Twojej dyspozycji przez całą dobę, 7 dni w tygodniu.',
      icon: faHeadset
    },
    {
      title: 'Pełny pakiet OC/AC',
      desc: 'Wszystkie pojazdy posiadają pełne ubezpieczenie autocasco z myślą o Twoim spokoju.',
      icon: faCarBurst
    },
  ]
}
