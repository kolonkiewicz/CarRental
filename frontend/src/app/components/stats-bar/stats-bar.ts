import { Component } from '@angular/core';

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
export class StatsBar {
  stats: StatItem[] =[
    { value: '300+', label: 'Pojazdów'},
    { value: '6', label: 'Miast w Polsce'},
    { value: '15 min', label: 'czs odbioru'},
    { value: '24/7', label: 'Wsparcie klienta'},
  ];
}
