import { Component, OnDestroy, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { MessageService } from 'primeng/api';
import { CarBookingService } from 'src/app/services/car-booking.service';
import { CarService } from 'src/app/services/car.service';
import { DateConverterService } from 'src/app/services/date-converter.service';
import { UserStoreService } from 'src/app/services/user-store.service';
import ValidateForm from '../helpers/validateForm';
import { Subscription } from 'rxjs';
import { Car } from 'src/app/interfaces/car';
import { Company } from 'src/app/interfaces/company';

@Component({
  selector: 'app-add-booking',
  templateUrl: './add-booking.component.html',
  styleUrls: ['./add-booking.component.css'],
})
export class AddBookingComponent implements OnInit, OnDestroy {
  bookForm!: FormGroup;
  formTitle: string = 'Add Car';
  addMode: boolean = false;
  companies: Company[] = [];
  cars: Car[] = [];
  carId: number = 0;
  selectedCar: any;
  timezoneOffset: any;
  minDate: any;
  maxDate: any;
  totalPrice: number = 0;
  totalHours: number = 0;
  pricingShow: boolean = false;
  timezoneSubscription!: Subscription;
  constructor(
    private userStore: UserStoreService,
    private carService: CarService,
    private carBookingService: CarBookingService,
    private dateConverterService: DateConverterService,
    private router: Router,
    private toast: MessageService,
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
    this.getTimezoneOffset();
    // Calling Initialize form function
    this.initializeForm();

    // Calling get Companies Function
    this.userStore.setSpinnerForStore(true);
    this.getCompanies();
  }
  ngOnDestroy(): void {
    this.timezoneSubscription.unsubscribe();
  }
  get f() {
    return this.bookForm.controls;
  }

  getTimezoneOffset() {
    this.timezoneSubscription = this.userStore.getTimezoneFromStore().subscribe((val) => {
      this.timezoneOffset = this.dateConverterService.getOffSetInMinutes(
        val.utcOffset
      );
    });
  }
  // Initialize Form
  initializeForm() {
    this.bookForm = this.fb.group({
      carId: new FormControl({ value: 0, disabled: true }, [
        Validators.required,
      ]),
      totalPrice: new FormControl({ value: 0, disabled: true }, [
        Validators.required,
      ]),
      bookedDuration: new FormControl({ value: [], disabled: true }, [
        Validators.required,
      ]),
      companyId: new FormControl('', [Validators.required]),
    });

    this.onSelectCompany();
    this.onSelectCar();
    this.onSelectBookDuration();
  }

  getCarsByCompanyId(id: number) {
    this.carService.getCarsByCompanyId(id).subscribe((res) => {
      this.cars = res;
      this.userStore.setSpinnerForStore(false);
    });
  }
  // Get Companies Function
  getCompanies() {
    this.carService.getCompanies().subscribe((res) => {
      this.companies = res;
      this.userStore.setSpinnerForStore(false);
    });
  }

  onSelectCompany() {
    this.f['companyId'].valueChanges.subscribe((res) => {
      this.userStore.setSpinnerForStore(true);
      this.getCarsByCompanyId(res);
      this.f['carId'].enable();
    });
  }
  onSelectCar() {
    this.f['carId'].valueChanges.subscribe((res) => {
      if (typeof res != 'number') {
        if (res.isActive) {
          this.selectedCar = res;
          this.selectedCar.availabilityFrom =
            this.dateConverterService.convertUtcToLocalDate(
              this.selectedCar.availabilityFrom,
              this.timezoneOffset
            );
          this.selectedCar.availabilityTo =
            this.dateConverterService.convertUtcToLocalDate(
              this.selectedCar.availabilityTo,
              this.timezoneOffset
            );
          this.minDate = new Date(this.selectedCar.availabilityFrom);
          this.maxDate = new Date(this.selectedCar.availabilityTo);
          console.log(this.selectedCar);
          this.f['bookedDuration'].enable();
          this.f['totalPrice'].enable();
          this.carId = res.id;
        } else {
          this.toast.add({
            severity: 'error',
            summary: 'Error',
            detail: 'This car is already booked. Please select another one',
          });
        }
      }
    });
  }

  onSelectBookDuration() {
    this.f['bookedDuration'].valueChanges.subscribe((res) => {
      if (res.length == 2 && res[0] != null && res[1] != null) {
        let hours = this.dateConverterService.calculateTimeDifference(
          res[0],
          res[1]
        );
        this.pricingShow = true;
        this.totalHours = hours;
        this.calculateTotalPrice();
      } else {
        this.totalHours = 0;
      }
    });
  }
  calculateTotalPrice() {
    this.totalPrice = this.selectedCar.price * this.totalHours;
    console.log(this.totalPrice);
  }
  bookCar() {
    if (this.bookForm.valid) {
      console.log(this.bookForm.value);
      this.bookForm.patchValue({ carId: this.carId });
      this.bookForm.patchValue({ totalPrice: this.totalPrice.toFixed() });
      this.carBookingService
        .bookCar(this.bookForm.value, this.timezoneOffset)
        .subscribe({
          next: (res: any) => {
            console.log(res);
            this.toast.add({
              severity: 'success',
              summary: 'Success',
              detail: 'Car booked successfully',
            });
            this.router.navigate(['/car-bookings']);
          },
          error: (err) => {
            console.log(err);
            this.toast.add({
              severity: 'error',
              summary: 'Error',
              detail: err,
            });
          },
        });
    } else {
      ValidateForm.validateAllFormFields(this.bookForm);
    }
  }
}
