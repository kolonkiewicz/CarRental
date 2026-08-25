import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { faCheck } from '@fortawesome/free-solid-svg-icons';
import { CarService } from '../../services/car.service';
import { ActivatedRoute } from '@angular/router';
import { Car } from '../../models/car';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-tabs',
  imports: [FontAwesomeModule, NgClass],
  templateUrl: './tabs.html',
  styleUrl: './tabs.css',
})
export class Tabs implements OnInit {
  faCheck = faCheck;

  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);
  private route = inject(ActivatedRoute);

  car!: Car;

  mainSpecs: { label: string; value: string | number }[] = [];
  specs: { label: string; value: string | number }[] = [];

  activeTab: 'opis' | 'spec' = 'opis';

  setActiveTab( tab: 'opis' | 'spec' = 'opis' ){
    this.activeTab = tab
  }


  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.carService.getCarById(id).subscribe({
      next: (car) => {
        this.car = car;

        this.mainSpecs = [
          { label: 'MOC', value: car.power },
          { label: 'ZASIĘG', value: car.range },
          { label: 'MIEJSCA', value: car.seats },
          { label: 'SKRZYNIA', value: car.transmission },
        ];

        this.specs = [
          { label: 'Marka', value: car.brand },
          { label: 'Model', value: car.model },
          { label: 'Kategoria', value: car.category },
          { label: 'Rok produkcji', value: car.year },
          { label: 'Liczba miejsc', value: car.seats },
          { label: 'Rodzaj paliwa', value: car.fuelType },
          { label: 'Skrzynia biegów', value: car.transmission },
          { label: 'Moc', value: car.power },
          { label: 'Zasięg', value: car.range },
          { label: 'Cena za dzień', value: `${car.pricePerDay} zł` },
        ];

        console.log('fdsf:', car);

        this.cdr.detectChanges();
      },
      error: (error) => {
        console.log('Bład podczas pobierania samochodu:', error);
      },
    });
  }

  highlights = [
    'Pełne ubezpieczenie w cenie',
    'Pełny zbiornik paliwa przy odbiorze',
    'Bezpłatna dostawa do lotniska',
    'GPS i uchwyt na telefon w standardzie',
  ];
}
