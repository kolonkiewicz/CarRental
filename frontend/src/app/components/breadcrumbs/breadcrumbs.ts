import { ChangeDetectorRef, Component, inject, OnInit } from '@angular/core';
import { RouterLink, Router, ActivatedRoute } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faChevronRight } from '@fortawesome/free-solid-svg-icons';
import { CarService } from '../../services/car.service';

@Component({
  selector: 'app-breadcrumbs',
  imports: [  FontAwesomeModule ],
  templateUrl: './breadcrumbs.html',
  styleUrl: './breadcrumbs.css',
})
export class Breadcrumbs implements OnInit {
  faChevronRight = faChevronRight;

  private carService = inject(CarService);
  private cdr = inject(ChangeDetectorRef);
  private route = inject(ActivatedRoute);

  category = '';
  brand = '';
  model = '';

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.carService.getCarById(id).subscribe({
      next: (car) => {
        this.category = car.category;
        this.brand = car.brand;
        this.model = car.model;

        console.log('fdsf:', car);

        this.cdr.detectChanges();
      },
      error: (error) =>{
        console.log('Bład podczas pobierania samochodu:', error);
      }
    });
  }



  constructor(private router: Router){}

  onBack(){
    this.router.navigate(['/fleet']);
  }
}
