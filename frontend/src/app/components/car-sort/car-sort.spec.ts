import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarSort } from './car-sort';

describe('CarSort', () => {
  let component: CarSort;
  let fixture: ComponentFixture<CarSort>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarSort],
    }).compileComponents();

    fixture = TestBed.createComponent(CarSort);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
