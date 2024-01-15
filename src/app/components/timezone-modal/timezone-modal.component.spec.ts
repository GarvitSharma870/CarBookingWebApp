import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimezoneModalComponent } from './timezone-modal.component';

describe('TimezoneModalComponent', () => {
  let component: TimezoneModalComponent;
  let fixture: ComponentFixture<TimezoneModalComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TimezoneModalComponent]
    });
    fixture = TestBed.createComponent(TimezoneModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
