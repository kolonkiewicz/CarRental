import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarDetailHeader } from './car-detail-header';

describe('CarDetailHeader', () => {
  let component: CarDetailHeader;
  let fixture: ComponentFixture<CarDetailHeader>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CarDetailHeader],
    }).compileComponents();

    fixture = TestBed.createComponent(CarDetailHeader);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
