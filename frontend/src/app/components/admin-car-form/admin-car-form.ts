import { Component, inject, input, output } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { 
  faL,
  faXmark
 } from '@fortawesome/free-solid-svg-icons';
import { Car } from '../../models/car';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { AdminService } from '../../services/admin-service';
import { ChangeCarDto } from '../../dtos/change-car.dto';
import { CreateCarDto } from '../../dtos/create-car.dto';


@Component({
  selector: 'app-admin-car-form',
  imports: [FontAwesomeModule, FormsModule, CommonModule],
  templateUrl: './admin-car-form.html',
  styleUrl: './admin-car-form.css',
})
export class AdminCarForm {
  faXmark = faXmark;

  car = input<Car | undefined>();
  close = output<void>();
  saved = output<void>();

  private adminService = inject(AdminService);
  showValidationError = false;

  get isEditMode(): boolean {
    return this.car() !== undefined;
  }

  formCar: Partial<Car> = {
    isAvailable: true,
    badge: null
  };
  
  ngOnInit(){
    if (this.car()){
      this.formCar = { ...this.car() };
    }
  }

  categories = [
  'Sportowe',
  'Sedan',
  'SUV',
  'Premium',
  'Elektryczne'
];

  fuelTypes = [
    'Benzyna',
    'Diesel',
    'Hybryda',
    'Elektryczny'
  ];

  transmissions = [
    'Manual',
    'Automat'
  ];

  badges = [
    'Bestseller',
    'Hot',
    'Premium',
    'Ikona',
    'Nowy',
    'Eco'
  ];

  saveCar(): void{
     if (
      !this.formCar.brand ||
      !this.formCar.model ||
      !this.formCar.category ||
      !this.formCar.imageUrl ||
      !this.formCar.description ||
      !this.formCar.year ||
      !this.formCar.seats ||
      !this.formCar.fuelType ||
      !this.formCar.transmission ||
      !this.formCar.power ||
      !this.formCar.range ||
      !this.formCar.pricePerDay
    ) {
      this.showValidationError = true;
      return;
    }
    this.showValidationError = false;

    if (this.isEditMode){
      const dto:ChangeCarDto = {
        brand: this.formCar.brand,
        model: this.formCar.model,
        category: this.formCar.category,
        imageUrl: this.formCar.imageUrl,
        description: this.formCar.description,
        year: this.formCar.year,
        seats: this.formCar.seats,
        fuelType: this.formCar.fuelType,
        transmission: this.formCar.transmission,
        power: this.formCar.power,
        range: this.formCar.range,
        pricePerDay: this.formCar.pricePerDay,
        isFeatured: this.formCar.isFeatured ?? false,
        isAvailable: this.formCar.isAvailable ?? true,
        badge: this.formCar.badge ?? null
    };

    this.adminService.changeCar(this.car()!.id, dto).subscribe({
      next: (response) => {
        console.log('ODPOWIEDŹ BACKENDU:', response);
        console.log('Wysłane DTO:', dto);
        this.saved.emit();
        this.close.emit();
      },
      error: (error) =>{
        console.log('Bład podcza aktualizacji samochodu:', error);
      }
    });
  } else{
      const dto: CreateCarDto = {
      brand: this.formCar.brand,
      model: this.formCar.model,
      category: this.formCar.category,
      imageUrl: this.formCar.imageUrl,
      description: this.formCar.description,
      year: this.formCar.year,
      seats: this.formCar.seats,
      fuelType: this.formCar.fuelType,
      transmission: this.formCar.transmission,
      power: this.formCar.power,
      range: this.formCar.range,
      pricePerDay: this.formCar.pricePerDay,
      isFeatured: this.formCar.isFeatured ?? false,
      isAvailable: this.formCar.isAvailable ?? true,
      badge: this.formCar.badge ?? null
    };

    this.adminService.createCar(dto).subscribe({
      next: () =>{
        console.log('samochod zostal dodany');
        this.saved.emit();
        this.close.emit();
      },
      error: (error) => {
        console.error('Bład podcczas dodawania samochodu:', error);
      }
    })
  }}
}
