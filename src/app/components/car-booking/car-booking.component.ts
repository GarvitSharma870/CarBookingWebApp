import { Component, OnDestroy, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { Subscription } from 'rxjs';
import { CarBooking } from 'src/app/interfaces/carBooking';
import { CarBookingService } from 'src/app/services/car-booking.service';
import { DateConverterService } from 'src/app/services/date-converter.service';
import { UserStoreService } from 'src/app/services/user-store.service';

@Component({
  selector: 'app-car-booking',
  templateUrl: './car-booking.component.html',
  styleUrls: ['./car-booking.component.css'],
})
export class CarBookingComponent implements OnInit, OnDestroy {
  timezoneOffset!: number;
  bookedCars: CarBooking[] = [];
  timezoneSubscription!: Subscription;
  bookingSubscription!:Subscription;
  constructor(
    private userStore: UserStoreService,
    private toast: MessageService,
    private dateConverterService: DateConverterService,
    private bookingService: CarBookingService
  ) {}
  ngOnInit(): void {
    this.getTimeZoneOffset();
    this.userStore.setSpinnerForStore(true);
    this.getCarBookings();
  }
  ngOnDestroy(): void {
    this.timezoneSubscription.unsubscribe();
    this.bookingSubscription.unsubscribe();
  }

  getCarBookings() {
    this.bookingSubscription = this.bookingService.getBookings().subscribe({
      next: (res) => {
        this.bookedCars = res;
        this.userStore.setSpinnerForStore(false);
      },
      error: (err) => {
        this.toast.add({ severity: 'error', summary: 'Error', detail: err });
        this.userStore.setSpinnerForStore(false);
      },
    });
  }

  getTimeZoneOffset() {
    this.timezoneSubscription = this.userStore.getTimezoneFromStore().subscribe((val) => {
      this.timezoneOffset = this.dateConverterService.getOffSetInMinutes(
        val.utcOffset
      );
      console.log(this.timezoneOffset);
    });
  }
  convertUtcToLocalTime(date: any) {
    return this.dateConverterService.convertUtcToLocalDate(
      date,
      this.timezoneOffset
    );
  }
  calculateHours(from: any, to: any) {
    const totalHours = this.dateConverterService.calculateTimeDifference(
      from,
      to
    );
    return totalHours;
  }
}
