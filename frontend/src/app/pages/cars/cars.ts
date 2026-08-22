import { Component } from '@angular/core';
import { FleetHeader } from "../../components/fleet-header/fleet-header";
import { CarFilter } from "../../components/car-filter/car-filter";
import { Footer } from "../../components/footer/footer";
import { Navbar } from "../../components/navbar/navbar";
import { CarSort } from "../../components/car-sort/car-sort";
import { CarGrid } from "../../components/car-grid/car-grid";

@Component({
  selector: 'app-cars',
  imports: [FleetHeader, CarFilter, Footer, Navbar, CarSort, CarGrid],
  templateUrl: './cars.html',
  styleUrl: './cars.css',
})
export class Cars {}
