import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddorEditModalComponent } from './addor-edit-modal.component';

describe('AddorEditModalComponent', () => {
  let component: AddorEditModalComponent;
  let fixture: ComponentFixture<AddorEditModalComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddorEditModalComponent]
    });
    fixture = TestBed.createComponent(AddorEditModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
