import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { 
  faPen,
  faTrash,
  faMagnifyingGlass
 } from '@fortawesome/free-solid-svg-icons';
import { CarService } from '../../services/car.service';
import { Car } from '../../models/car';
import { FormsModule } from '@angular/forms';
import { AdminCarForm } from '../admin-car-form/admin-car-form';


@Component({
  selector: 'app-admin-fleet',
  imports: [FontAwesomeModule, FormsModule, AdminCarForm],
  templateUrl: './admin-fleet.html',
  styleUrl: './admin-fleet.css',
})
export class AdminFleet implements OnInit{
  faPen = faPen;
  faTrash = faTrash;
  faMagnifyingGlass = faMagnifyingGlass;

  private cdr = inject(ChangeDetectorRef)
  private carService = inject(CarService);

  searchTerm = '';
  selectedStatus = 'Wszystkie';
  filteredCars: Car[] = [];

  cars: Car[] = [];

  ngOnInit(): void {
    this.carService.getCars().subscribe({
      next: (cars) =>{
        this.cars = cars;
        this.filteredCars = cars;
        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('error loading cars for filter', error);
      }
    });
  }

  get availableCarsCount(): number {
    return this.filteredCars.filter(car => car.isAvailable).length;
  }
  
  searchCar(): void{
    this.filterCars(); 
  }

  filterByStatus(status: string): void{
    this.selectedStatus = status;
    this.filterCars();
  }

  filterCars(): void{
    const search = this.searchTerm.toLowerCase().trim();

    this.filteredCars = this.cars.filter( cars => {
      
      const matchesSearch = 
        cars.model.toLowerCase().includes(search) ||
        cars.brand.toLowerCase().includes(search);
      
      const matchesStatus =
        this.selectedStatus === 'Wszystkie' ||
        ( this.selectedStatus === 'Dostępne' && cars.isAvailable ) ||
        ( this.selectedStatus === 'Niedostępne' && !cars.isAvailable);

      return matchesSearch && matchesStatus;
    });
  }

  showCarModel = false;
  selectedCar?: Car;

  openAddCar(): void {
    this.selectedCar = undefined;
    this.showCarModel = true;
  }

  openEditCar(car: Car): void{
    this.selectedCar = car;
    this.showCarModel = true;
  }

  closeCarModel():void {
    this.showCarModel = false;
    this.selectedCar = undefined;
  }
  
}
