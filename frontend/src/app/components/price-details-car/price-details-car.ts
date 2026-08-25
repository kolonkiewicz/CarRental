import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


import { 
  faLocationDot,
  faChevronDown,
  faCalendar,
  faCheck,
  faArrowRight,
  faShield,
  faClock,
  faZap
} from '@fortawesome/free-solid-svg-icons';
import { CarService } from '../../services/car.service';
import { ActivatedRoute } from '@angular/router';
import { Car } from '../../models/car';
import { FormsModule } from '@angular/forms';
import { NgClass } from '@angular/common';


@Component({
  selector: 'app-price-details-car',
  imports: [ FontAwesomeModule, FormsModule, NgClass ],
  templateUrl: './price-details-car.html',
  styleUrl: './price-details-car.css',
})
export class PriceDetailsCar implements OnInit {
  faLocationDot = faLocationDot;
  faChevronDown = faChevronDown;
  faCalendar = faCalendar;
  faCheck = faCheck;
  faArrowRight = faArrowRight;
  faShield = faShield;
  faClock = faClock;
  faZap = faZap;

  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);
  private route = inject(ActivatedRoute);

  pricePerDay = 0;

  pickupLoc = 'Opole';
  pickupDate = '';
  returnDate = '';

  locations = [
    'Opole',
    'Wrocław',
    'Katowice',
    'Kraków'
  ];

  days = 1;
  total = 0;

  booked = false;

  car: any = {
    price: 0,
    available: true
  };

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.carService.getCarById(id).subscribe({
      next: (car) => {
        this.pricePerDay = car.pricePerDay;

        this.car = {
          ...car,
          price: car.pricePerDay,
          available: car.isAvailable
        };

        this.pickupDate = this.getToday();
        this.returnDate = this.getTommorow();

        this.calculatePrice();

        console.log('price details:', this.pricePerDay);

        this.cdr.detectChanges();
      },
      error: (error) => {
        console.log('Bład podczas pobierania samochodu:', error);
      },
    });
  }

  calculatePrice(): void{
    if (!this.pickupDate || !this.returnDate){
      this.days = 0;
      this.total = 0;
      
      return;
    }

    const pickup = new Date(this.pickupDate);
    const returnDate = new Date(this.returnDate);

    const difference = 
      returnDate.getTime() - pickup.getTime();
    
    const millisecondsPerDay = 1000 * 60 * 60 * 24;

    const calculatedDays = 
      Math.ceil( difference / millisecondsPerDay );
    
    if( calculatedDays <= 0){
      this.days = 0;
      this.total = 0;
      return;
    }

    this.days = calculatedDays;
    this.total = this.pricePerDay * this.days;
  }

  handleBooking(): void{
    if ( !this.isDateValid() ){
      return;
    }

    this.calculatePrice();

    if ( this.total <= 0 ){
      return
    }

    console.log('Rezerwacja:');
    console.log('Samochód:', this.car);
    console.log('Lokalizacja:', this.pickupLoc);
    console.log('Odbiór:', this.pickupDate);
    console.log('Zwrot:', this.returnDate);
    console.log('Liczba dni:', this.days);
    console.log('Cena:', this.total);

    this.booked = true;
  }

  isDateValid(): boolean{
    if ( !this.pickupDate || !this.returnDate ){
      return false;
    }

    const pickup = new Date(this.pickupDate);
    const returnDate = new Date(this.returnDate);

    return returnDate > pickup
  }

  getToday(): string{
    const today = new Date();

    return today.toISOString().split('T')[0];
  }

  getTommorow(): string{

    const tomorrow = new Date();

    tomorrow.setDate(tomorrow.getDate() + 1);

    return tomorrow.toISOString().split('T')[0];
  }
}
