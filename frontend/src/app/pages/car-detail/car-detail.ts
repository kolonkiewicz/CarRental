import { Component } from '@angular/core';
import { Footer } from "../../components/footer/footer";
import { Navbar } from "../../components/navbar/navbar";
import { CarDetailHeader } from "../../components/car-detail-header/car-detail-header";
import { Breadcrumbs } from "../../components/breadcrumbs/breadcrumbs";
import { Tabs } from "../../components/tabs/tabs";
import { PriceDetailsCar } from "../../components/price-details-car/price-details-car";
import { HelpDetailsCar } from '../../components/help-details-car/help-details-car';
import { GalleryDetailCar } from "../../components/gallery-detail-car/gallery-detail-car";

@Component({
  selector: 'app-car-detail',
  imports: [Footer, Navbar, CarDetailHeader, Breadcrumbs, Tabs, PriceDetailsCar, HelpDetailsCar, GalleryDetailCar],
  templateUrl: './car-detail.html',
  styleUrl: './car-detail.css',
})
export class CarDetail {}
