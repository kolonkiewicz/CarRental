import { Component, inject, OnInit, input, effect, ChangeDetectorRef, inputBinding, output } from '@angular/core';
import { CarCard } from '../car-card/car-card';
import { Car } from '../../models/car';
import { CarService } from '../../services/car.service';

@Component({
  selector: 'app-car-grid',
  imports: [CarCard],
  templateUrl: './car-grid.html',
  styleUrl: './car-grid.css',
})
export class CarGrid implements OnInit{

  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);

  filteredCars: Car [] = [];
  cars: Car[] = [];

  selectedCategory = input<string | null>(null);
  maxPrice = input<number | null>(null);
  selectedFuel = input<string | null>(null);
  selectedTransmission = input<string | null>(null);
  selectedSeats = input<number | null>(null);
  availableOnly = input<boolean>(false);
  searchTerm = input<string>('');
  selectedSort = input<string>('priceAsc');

  carsCount = output<number>();

  ngOnInit(): void {
    this.carService.getCars().subscribe({
      next: (cars) =>{
        console.log('cars loaded', cars);
        this.cars = cars;
        this.applyFilters();

        this.cdr.detectChanges();

      },
      error: (error) => {
        console.error('Error loading cars:', error);
      }
      
    });
  }

  ngOnChanges(): void{

    this.applyFilters();
  }

  applyFilters(): void{
    const category = this.selectedCategory();
    const maxPrice = this.maxPrice();
    const fuel = this.selectedFuel();
    const transmission = this.selectedTransmission();
    const seats = this.selectedSeats();
    const availableOnly = this.availableOnly();
    const search = this.searchTerm().trim().toLowerCase();
    
    this.filteredCars = this.cars.filter( car => {
      
      const matchesCategoty = 
        !category ||
        category == 'Wszystkie' ||
        car.category === category;

      const matchesPrice = 
        maxPrice == null ||
        car.pricePerDay <= maxPrice;
      
      const matchesFuel =
        !fuel ||
        fuel === 'Wszystkie' ||
        car.fuelType === fuel;
      
      const matchesTransmission =
        !transmission ||
        transmission === 'Obie' ||
        car.transmission === transmission;
      
      const matchesSeats =
        seats == null ||
        car.seats === seats;
      
      const matchesAvailability =
        !availableOnly ||
        car.isAvailable;
      
      const matchesSearch =
        !search ||
        car.brand.toLowerCase().includes(search) ||
        car.model.toLowerCase().includes(search);

        return matchesCategoty && matchesPrice && matchesFuel && matchesTransmission && matchesSeats && matchesAvailability && matchesSearch;
    })

    this.sortCars();
    setTimeout(() =>{
      this.carsCount.emit(this.filteredCars.length);
    });

    this.cdr.detectChanges();
  }

  sortCars(): void{
    const sort = this.selectedSort();

    switch (sort){
      case 'priceAsc':
        this.filteredCars.sort(
          (a, b) => a.pricePerDay - b.pricePerDay
        );
        break;
      
      case 'priceDesc':
        this.filteredCars.sort(
          (a, b) => b.pricePerDay - a.pricePerDay
        );
        break;

      case 'newest':
        this.filteredCars.sort(
          (a, b) => b.year - a.year
        );
      break;
    }
  }
}
