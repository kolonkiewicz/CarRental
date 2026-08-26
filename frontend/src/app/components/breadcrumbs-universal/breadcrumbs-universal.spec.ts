import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BreadcrumbsUniversal } from './breadcrumbs-universal';

describe('BreadcrumbsUniversal', () => {
  let component: BreadcrumbsUniversal;
  let fixture: ComponentFixture<BreadcrumbsUniversal>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BreadcrumbsUniversal],
    }).compileComponents();

    fixture = TestBed.createComponent(BreadcrumbsUniversal);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
