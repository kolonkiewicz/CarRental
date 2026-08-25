import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PriceDetailsCar } from './price-details-car';

describe('PriceDetailsCar', () => {
  let component: PriceDetailsCar;
  let fixture: ComponentFixture<PriceDetailsCar>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PriceDetailsCar],
    }).compileComponents();

    fixture = TestBed.createComponent(PriceDetailsCar);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
