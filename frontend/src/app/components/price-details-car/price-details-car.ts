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
  faZap,
  faCircleExclamation
} from '@fortawesome/free-solid-svg-icons';
import { CarService } from '../../services/car.service';
import { ActivatedRoute } from '@angular/router';
import { Car } from '../../models/car';
import { FormsModule } from '@angular/forms';
import { NgClass } from '@angular/common';
import { ReservationService } from '../../services/reservation-service';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule } from '@angular/material/core';

interface ReservedDate {
  startDate: string;
  endDate: string;
}

@Component({
  selector: 'app-price-details-car',
  imports: [ FontAwesomeModule, FormsModule, NgClass, MatDatepickerModule, MatInputModule, MatNativeDateModule ],
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
  faCircleExclamation = faCircleExclamation;

  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);
  private route = inject(ActivatedRoute);
  private reservationService = inject(ReservationService);

  pricePerDay = 0;
  reservedDates: ReservedDate[] = [];

  pickupLoc = 'Opole';
  returnLoc = 'Opole';
  pickupDate: Date | null = null;
  returnDate: Date | null = null;

  locations = [
    'Opole',
    'Wrocław',
    'Katowice',
    'Kraków'
  ];

  days = 1;
  total = 0;

  booked = false;
  bookingError = '';

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
        this.returnDate = this.getTommorrow();

        this.calculatePrice();

        this.reservationService.getCarReservations(this.car.id).subscribe({
          next: (reservations) => {

            this.reservedDates = reservations;
            console.log('Zajęte terminy:', reservations);
          },
          error: (error) => {
            console.log('Błąd podczas pobierania terminów:', error);
          }
        });

        this.cdr.detectChanges();
      },
      error: (error) => {
        console.log('Bład podczas pobierania samochodu:', error);
      },
    });
    
  }

  dateFilter = (date: Date | null): boolean =>{
    if (!date){
      return false;
    }

    const dateString = this.formatDate(date);

    const today = this.formatDate(this.getToday());

    if (dateString < today){
      return false
    }

    return !this.reservedDates.some( reservation =>
      dateString >= reservation.startDate &&
      dateString <= reservation.endDate
    );
  };

  formatDate(date: Date): string{
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, '0');
    const day = String(date.getDate()).padStart(2, '0');

    return `${year}-${month}-${day}`;
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

    const pickupDate = this.pickupDate;
    const returnDate = this.returnDate;

    if (!pickupDate || !returnDate){
      return;
    }

    const reservation = {
      carId: this.car.id,
      startDate: this.formatDate(pickupDate),
      endDate: this.formatDate(returnDate),
      pickupLocation: this.pickupLoc,
      returnLocation: this.returnLoc
    }

    this.reservationService.createReservation(reservation).subscribe({
      next: ( response ) => {
        console.log('Rezerwacja utworzona:', response);
        this.booked = true;
        this.cdr.detectChanges();
      },
      error: ( error ) =>{
        console.log('Bład podczas rezerwacji', error);

        if ( error.status === 401){
          this.bookingError = 'Musisz być zalogowany, aby zarezerwować samochód.';
          
        }else if ( error.status === 400){
          this.bookingError = 'Samochod jest niedostępny w tym terminie.';
        }else if ( error.status === 404 ){
          this.bookingError = 'Nie znaleziono wybranego samochodu.';
        }else{
          this.bookingError = 'Wystąpił bład podczas tworzenia rezerwacji.'
        }

        this.cdr.detectChanges();
      }
    })

  }

  isDateValid(): boolean{
    if ( !this.pickupDate || !this.returnDate ){
      return false;
    }

    return this.returnDate > this.pickupDate
  }

  getToday(): Date{
    const today = new Date();

    today.setHours( 0, 0, 0, 0 );

    return today;
  }

  getTommorrow(): Date{

    const tomorrow = this.getToday();

    tomorrow.setDate( tomorrow.getDate() + 1 );

    return tomorrow;
  }
}
