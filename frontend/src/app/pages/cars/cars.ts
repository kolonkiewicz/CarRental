import { Component } from '@angular/core';
import { FleetHeader } from "../../components/fleet-header/fleet-header";
import { CarFilter } from "../../components/car-filter/car-filter";
import { Footer } from "../../components/footer/footer";
import { Navbar } from "../../components/navbar/navbar";
import { CarSort } from "../../components/car-sort/car-sort";
import { CarGrid } from "../../components/car-grid/car-grid";
import { faL } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-cars',
  imports: [FleetHeader, CarFilter, Footer, Navbar, CarSort, CarGrid],
  templateUrl: './cars.html',
  styleUrl: './cars.css',
})
export class Cars {
  selectedCategory: string | null =null;
  maxPrice: number | null = null;
  selectedFuel: string | null = null;
  selectedTransmission: string | null = null;
  selectedSeats: number | null = null;
  availableOnly = false;
  searchTerm: string = '';
  selectedSort: string = 'priceAsc';
  carsCount: number = 0;
  
  onCategorySelected( category: string): void{
    this.selectedCategory = category;
  }

  onPriceSelected( price: number ): void{
    this.maxPrice = price;

    console.log('maks cena',price);
  }

  onFuelSelected( fuel: string ): void{
    this.selectedFuel = fuel;
  }

  onTransmissionSelected( transmission: string ): void{
    this.selectedTransmission = transmission;
  }

  onSeatselected( seats: number | null ): void{
    this.selectedSeats = seats;
  }

  onAvailableSelected(available: boolean): void{
    this.availableOnly = available;
  }
  
  onSearchSelected( search:string ): void{
    this.searchTerm = search;
  }

  onSortSelected( sort: string ): void{
    this.selectedSort = sort;
  }

  onCarsCountChanged(count: number): void{
    this.carsCount = count;
  }
}
