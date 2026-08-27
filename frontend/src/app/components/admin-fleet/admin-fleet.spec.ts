import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminFleet } from './admin-fleet';

describe('AdminFleet', () => {
  let component: AdminFleet;
  let fixture: ComponentFixture<AdminFleet>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdminFleet],
    }).compileComponents();

    fixture = TestBed.createComponent(AdminFleet);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
