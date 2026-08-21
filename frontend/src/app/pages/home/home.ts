import { Component } from '@angular/core';
import { Hero } from "../../components/hero/hero";
import { BookingForm } from "../../components/booking-form/booking-form";
import { StatsBar } from "../../components/stats-bar/stats-bar";
import { FeaturedCars } from "../../components/featured-cars/featured-cars";
import { WhyUs } from "../../components/why-us/why-us";
import { Opinions } from "../../components/opinions/opinions";
import { Cta } from "../../components/cta/cta";
import { Experience } from "../../components/experience/experience";

@Component({
  selector: 'app-home',
  imports: [Hero, StatsBar, FeaturedCars, WhyUs, Opinions, Cta, Experience],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {}
