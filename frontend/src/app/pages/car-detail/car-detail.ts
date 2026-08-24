import { Component } from '@angular/core';
import { Footer } from "../../components/footer/footer";
import { Navbar } from "../../components/navbar/navbar";
import { CarDetailHeader } from "../../components/car-detail-header/car-detail-header";

@Component({
  selector: 'app-car-detail',
  imports: [Footer, Navbar, CarDetailHeader],
  templateUrl: './car-detail.html',
  styleUrl: './car-detail.css',
})
export class CarDetail {}
