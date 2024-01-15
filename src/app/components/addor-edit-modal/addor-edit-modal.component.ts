import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { MessageService } from 'primeng/api';
import { CarService } from 'src/app/services/car.service';
import ValidateForm from '../helpers/validateForm';
import { DateConverterService } from 'src/app/services/date-converter.service';
import { UserStoreService } from 'src/app/services/user-store.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-addor-edit-modal',
  templateUrl: './addor-edit-modal.component.html',
  styleUrls: ['./addor-edit-modal.component.css'],
})
export class AddorEditModalComponent implements OnInit, OnDestroy {
  carForm!: FormGroup;
  carId!: number;
  formTitle: string = 'Add Car';
  addMode: boolean = false;
  companies: any[] = [];
  carModel: any;
  timezoneOffset: number = 0;

  companiesSubscription!:Subscription;
  timezoneSubscription!: Subscription
  event: EventEmitter<any> = new EventEmitter();
  constructor(
    private userStore: UserStoreService,
    private dateConverterService: DateConverterService,
    private router: Router,
    private toast: MessageService,
    private bsModalRef: BsModalRef,
    private fb: FormBuilder,
    private carService: CarService
  ) {}

  ngOnInit(): void {
    this.addMode = !this.carId;
    this.getTimezoneOffset();
    // Calling Initialize form function
    this.initializeForm();

    // Calling get Companies Function
    this.userStore.setSpinnerForStore(true);
    this.getCompanies();

    // Calling Initialize Form Function in edit mode
    if (!this.addMode) {
      this.initializeFormWithEditMode();
    }
  }
  ngOnDestroy(): void {
    this.companiesSubscription.unsubscribe();
    this.timezoneSubscription.unsubscribe();
  }
  get f() {
    return this.carForm.controls;
  }
  getTimezoneOffset() {
    this.timezoneSubscription = this.userStore.getTimezoneFromStore().subscribe((val) => {
      console.log(val);
      this.timezoneOffset = this.dateConverterService.getOffSetInMinutes(
        val.utcOffset
      );
      console.log(this.timezoneOffset);
    });
  }

  // Initialize Form
  initializeForm() {
    this.carForm = this.fb.group({
      carName: new FormControl('', [Validators.required]),
      number: new FormControl('', [Validators.required]),
      price: new FormControl(null, [Validators.required]),
      slots: new FormControl(null, [Validators.required]),
      availableTime: new FormControl([], [Validators.required]),
      companyId: new FormControl('', [Validators.required]),
    });
  }

  // Initialize Form in Edit Mode
  initializeFormWithEditMode() {
    this.formTitle = 'Edit Car';
    this.carService.getCarById(this.carId).subscribe((res) => {
      this.carModel = res;
      let availableTimes = [];
      availableTimes.push(
        new Date(
          this.dateConverterService.convertUtcToLocalDate(
            res.availabilityFrom,
            this.timezoneOffset
          )
        )
      );
      availableTimes.push(
        new Date(
          this.dateConverterService.convertUtcToLocalDate(
            res.availabilityTo,
            this.timezoneOffset
          )
        )
      );
      this.carForm.patchValue(res);
      this.carForm.patchValue({ availableTime: availableTimes });
      this.userStore.setSpinnerForStore(false);
    });
  }

  // Get Companies Function
  getCompanies() {
    this.companiesSubscription = this.carService.getCompanies().subscribe((res) => {
      console.log(res);
      this.companies = res;
      if(this.addMode){
        this.userStore.setSpinnerForStore(false);
      }
    });
  }

  onClose() {
    this.bsModalRef.hide();
  }

  addCar() {
    if (this.carForm.valid) {
      console.log(this.carForm.value);
      this.carService.addCar(this.carForm.value).subscribe({
        next: (res: any) => {
          console.log(res);
          this.toast.add({
            severity: 'success',
            summary: 'Success',
            detail: 'Car added successfully',
          });
          this.event.emit('Ok');
          this.bsModalRef.hide();
          this.router.navigate(['/']);
        },
        error: (err) => {
          console.log(err);
          this.toast.add({ severity: 'error', summary: 'Error', detail: err });
        },
      });
    } else {
      ValidateForm.validateAllFormFields(this.carForm);
    }
  }
  editCar() {
    if (this.carForm.valid) {
      console.log(this.carForm.value);
      this.carService.editCar(this.carForm.value, this.carId).subscribe({
        next: (res: any) => {
          console.log(res);
          this.toast.add({
            severity: 'success',
            summary: 'Success',
            detail: 'Car updated successfully',
          });
          this.event.emit('Ok');
          this.bsModalRef.hide();
          this.router.navigate(['/']);
        },
        error: (err) => {
          console.log(err);
          this.toast.add({ severity: 'error', summary: 'Error', detail: err });
        },
      });
    } else {
      ValidateForm.validateAllFormFields(this.carForm);
    }
  }
}
