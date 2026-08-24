import { Component, OnInit, inject, ChangeDetectorRef } from '@angular/core';
import { CarService } from '../../services/car.service';
import { count } from 'rxjs';

interface StatItem{
  value: string;
  label: string;
}

@Component({
  selector: 'app-stats-bar',
  imports: [],
  templateUrl: './stats-bar.html',
  styleUrl: './stats-bar.css',
})
export class StatsBar implements OnInit {

  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);

  carsCount:number = 0;

  ngOnInit(): void{
      this.carService.getCarsCount().subscribe({
        next: (count) => {
          this.carsCount = count;
          console.log('featuredcars', count);
          this.cdr.detectChanges();
        },
        error: (error) => {
          console.log("Blad podczas pobierania featured cars", error);
        }
      });
    }

  get stats(): StatItem[] {
    return [
      { value: `${this.carsCount}+`, label: 'Pojazdów' },
      { value: '6', label: 'Miast w Polsce' },
      { value: '15 min', label: 'Czas odbioru' },
      { value: '24/7', label: 'Wsparcie klienta' },
    ];
  }
}
