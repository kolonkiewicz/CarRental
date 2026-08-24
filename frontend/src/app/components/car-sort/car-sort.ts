import { Component, output, input } from '@angular/core';

@Component({
  selector: 'app-car-sort',
  imports: [],
  templateUrl: './car-sort.html',
  styleUrl: './car-sort.css',
})
export class CarSort {
  carsCount = input<number>(0);

  sortSelected = output<string>();
  selectedSort: string = 'priceAsc';
  

  onSortChange( sort:string ): void{
    this.selectedSort = sort;

    this.sortSelected.emit(sort);
  }

  getCarsLabel(): string{
    const count = this.carsCount();

    if (count == 1){
      return 'pojazd';
    }

    if ( count >= 2 && count <=4 ){
      return 'pojazdy';
    }

    return 'pojazdów';
  }
}
