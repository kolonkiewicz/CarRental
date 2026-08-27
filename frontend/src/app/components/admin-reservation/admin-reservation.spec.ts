import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminReservation } from './admin-reservation';

describe('AdminReservation', () => {
  let component: AdminReservation;
  let fixture: ComponentFixture<AdminReservation>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdminReservation],
    }).compileComponents();

    fixture = TestBed.createComponent(AdminReservation);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
