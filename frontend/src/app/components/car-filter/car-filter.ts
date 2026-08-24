import { Component, inject, OnInit, output, ChangeDetectorRef } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { Car } from '../../models/car';
import { FormsModule } from '@angular/forms';

import{
  faRotateLeft,
  faSearch,
  faSliders
} from '@fortawesome/free-solid-svg-icons';
import { CarService } from '../../services/car.service';
import { range } from 'rxjs';

@Component({
  selector: 'app-car-filter',
  imports: [ FontAwesomeModule, FormsModule ],
  templateUrl: './car-filter.html',
  styleUrl: './car-filter.css',
})
export class CarFilter implements OnInit {
  faSearch = faSearch;
  faRotateLeft = faRotateLeft;
  faSliders = faSliders;

  private cdr = inject(ChangeDetectorRef)
  private carService = inject(CarService);

  cars: Car[] = [];
  categories: string[] = [];

  categorySelected = output<string>();
  selectedCategory:string = 'Wszystkie';

  minPrice: number = 0;
  maxPrice: number = 2000;
  selectedMaxPrice: number = this.maxPrice;
  priceSelected = output<number>();

  
  fuels: string[] = [];
  selectedFuel:string = 'Wszystkie';
  fuelSelected = output<string>();

  transmissions: string[] = [];
  selectedTransmission: string = 'Obie';
  transmissionSelected = output<string>();

  seatsOptions: number[] = [];
  selectedSeats: number | null = null;
  seatsSelected = output<number | null>();

  availableOnly = false;
  availableSelected = output<boolean>();

  searchTerm: string = '';
  searchSelected = output<string>();

  ngOnInit(): void{
    this.carService.getCategories().subscribe({
      next: (categories) => {
        this.categories = ['Wszystkie', ...categories];
        
        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('error loading categories:', error);
      }
    });

    this.carService.getCars().subscribe({
      next: (cars) =>{
        this.cars = cars;
        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('error loading cars for filter', error);
      }
    });

    this.carService.getPriceRange().subscribe({
      next: (range) => {
        this.minPrice = range.minPrice;
        this.maxPrice = range.maxPrice;

        this.selectedMaxPrice = range.maxPrice;

        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('error loading price range', error);
      }
    });

    this.carService.getFuels().subscribe({
      next: (fuels) =>{
        this.fuels = ['Wszystkie', ...fuels];

        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('error loading fuel', error);
      }
    });

    this.carService.getTransmission().subscribe({
      next: (transmissions) => {
        this.transmissions = ['Obie', ...transmissions]

        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('error loading transmission', error);
      } 
    });
    this.carService.getSeats().subscribe({
      next: (seats) => {
        this.seatsOptions = seats;

        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('error loading seats', error);
      } 
    })
  }


  onCategoryChange(category: string): void {
    this.selectedCategory = category;

    this.categorySelected.emit(category);
  }

  getCategoryCount(category: string): number {

    if (category === 'Wszystkie') {
      return this.cars.length;
    }

    return this.cars.filter(
      car => car.category === category
    ).length;

  }

  onPriceChange(): void{
    this.priceSelected.emit(this.selectedMaxPrice);
  }

  onFuelChange( fuel: string): void{
    this.selectedFuel = fuel;

    this.fuelSelected.emit(fuel);
  }

  onTransmissionChange( transmission: string ): void{
    this.selectedTransmission = transmission;

    this.transmissionSelected.emit(transmission);
  }

  onSeatsChange( seats: number ): void{
    if (this.selectedSeats === seats){
      this.selectedSeats = null;
    }else{
      this.selectedSeats = seats;
    }
    this.seatsSelected.emit(this.selectedSeats);
  }

  onAvailableChange(): void{
    this.availableOnly = !this.availableOnly;

    this.availableSelected.emit(this.availableOnly);
  }

  onSearchChange(): void{
    this.searchSelected.emit(this.searchTerm);
  }

  onResetFilters(): void {
  this.selectedCategory = 'Wszystkie';

  this.selectedMaxPrice = this.maxPrice;

  this.selectedFuel = 'Wszystkie';

  this.selectedTransmission = 'Obie';

  this.selectedSeats = null;

  this.availableOnly = false;
  this.searchTerm = '';

  this.categorySelected.emit(this.selectedCategory);
  this.priceSelected.emit(this.selectedMaxPrice);
  this.fuelSelected.emit(this.selectedFuel);
  this.transmissionSelected.emit(this.selectedTransmission);
  this.seatsSelected.emit(this.selectedSeats);
  this.availableSelected.emit(this.availableOnly);
  this.searchSelected.emit(this.searchTerm);
}
get activeFiltersCount(): number {
  let count = 0;

  if (this.selectedCategory !== 'Wszystkie') {
    count++;
  }

  if (this.selectedMaxPrice < this.maxPrice) {
    count++;
  }

  if (this.selectedFuel !== 'Wszystkie') {
    count++;
  }

  if (this.selectedTransmission !== 'Obie') {
    count++;
  }

  if (this.selectedSeats !== null) {
    count++;
  }

  if (this.availableOnly) {
    count++;
  }

  if (this.searchTerm.trim() !== ''){
    count++;
  }

  return count;
}
}
