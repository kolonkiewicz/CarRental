import { Component } from '@angular/core';

export interface Opinion{
  name: string;
  role: string;
  text: string;
  rating: number;
}

@Component({
  selector: 'app-opinions',
  imports: [],
  templateUrl: './opinions.html',
  styleUrl: './opinions.css',
})
export class Opinions {
  opinion: Opinion[] = [
    {
      name: 'Michał Kowalski',
      role: 'Wynajem weekendowy',
      text: 'Auto podstawione dokładnie na czas, w stanie idealnym. Porsche GT3 na torze i trasie zrobiło niesamowite wrażenie. Napewno wrócę!',
      rating: 5,
    },
    {
      name: 'Piotr Wiśniewski',
      role: 'Wynajem biznesowy',
      text: 'Pełen profesjonalizm. Formalności załatwione w 5 minut, bez zbędnej biurokracji i kaucji. BMW M5 sprawdza się idealnie w trasach.',
      rating: 5,
    },
    {
      name: 'Kamil Nowak',
      role: 'Wynajem na ślub',
      text: 'G63 zrobiło ogromne wrażenie na gościach. Kontakt z obsługą 24/7 na najwyższym poziomie, auto czyste i pachnące nowością.',
      rating: 5,
    },
  ];

  getStars(rating: number): number[] {
    return Array(rating).fill(0);
  }
}
