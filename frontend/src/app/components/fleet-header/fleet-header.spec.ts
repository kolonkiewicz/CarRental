import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FleetHeader } from './fleet-header';

describe('FleetHeader', () => {
  let component: FleetHeader;
  let fixture: ComponentFixture<FleetHeader>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FleetHeader],
    }).compileComponents();

    fixture = TestBed.createComponent(FleetHeader);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
