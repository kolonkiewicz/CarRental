import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelpDetailsCar } from './help-details-car';

describe('HelpDetailsCar', () => {
  let component: HelpDetailsCar;
  let fixture: ComponentFixture<HelpDetailsCar>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HelpDetailsCar],
    }).compileComponents();

    fixture = TestBed.createComponent(HelpDetailsCar);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
