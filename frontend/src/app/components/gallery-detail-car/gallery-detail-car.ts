import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { CarService } from '../../services/car.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-gallery-detail-car',
  imports: [],
  templateUrl: './gallery-detail-car.html',
  styleUrl: './gallery-detail-car.css',
})
export class GalleryDetailCar implements OnInit {
  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);
  private route = inject(ActivatedRoute);

  imageUrl = "";
  carname = "";

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.carService.getCarById(id).subscribe({
      next: (car) => {
        this.imageUrl = car.imageUrl;
        this.carname = car.brand + ' ' + car.model;

        console.log('imageURL details:', this.imageUrl , this.carname);

        this.cdr.detectChanges();
      },
      error: (error) => {
        console.log('Bład podczas pobierania samochodu:', error);
      },
    });
  }
}
