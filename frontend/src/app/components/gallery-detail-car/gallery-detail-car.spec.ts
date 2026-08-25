import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GalleryDetailCar } from './gallery-detail-car';

describe('GalleryDetailCar', () => {
  let component: GalleryDetailCar;
  let fixture: ComponentFixture<GalleryDetailCar>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GalleryDetailCar],
    }).compileComponents();

    fixture = TestBed.createComponent(GalleryDetailCar);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
