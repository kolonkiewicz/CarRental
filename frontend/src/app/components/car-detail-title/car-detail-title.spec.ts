import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarDetailTitle } from './car-detail-title';

describe('CarDetailTitle', () => {
  let component: CarDetailTitle;
  let fixture: ComponentFixture<CarDetailTitle>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarDetailTitle],
    }).compileComponents();

    fixture = TestBed.createComponent(CarDetailTitle);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
