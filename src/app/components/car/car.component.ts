import { Component, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { MessageService } from 'primeng/api';
import { CarService } from 'src/app/services/car.service';
import { BsModalService, BsModalRef, ModalOptions } from 'ngx-bootstrap/modal';
import { AddorEditModalComponent } from '../addor-edit-modal/addor-edit-modal.component';
import { TimezoneModalComponent } from '../timezone-modal/timezone-modal.component';
import { DateConverterService } from 'src/app/services/date-converter.service';
import { DeleteModalComponent } from '../delete-modal/delete-modal.component';
import { Subscription } from 'rxjs';
import { UserStoreService } from 'src/app/services/user-store.service';
import { Car } from 'src/app/interfaces/car';
@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
})
export class CarComponent implements OnInit, OnDestroy {
  cars: Car[] = [];
  bsModalRef!: BsModalRef;
  timezoneOffset: number=0;
  isShow: boolean = false;
  carId: number = 0;
  carSubscription!: Subscription
  timezoneSubscription!: Subscription
  constructor(
    private dateConverterService: DateConverterService,
    private modalService: BsModalService,
    private toast: MessageService,
    private carService: CarService,
    private userStore: UserStoreService
  ) {}
  ngOnInit(): void {
    this.getTimezoneOffset();
    if(this.timezoneOffset == 0){
    this.showTimeZoneModal();
    }
  }
  ngOnDestroy(): void {
    this.carSubscription.unsubscribe();
    this.timezoneSubscription.unsubscribe();
  }
  getTimezoneOffset() {
    this.timezoneSubscription = this.userStore.getTimezoneFromStore().subscribe((val) => {
      if(val != ""){
      this.timezoneOffset = this.dateConverterService.getOffSetInMinutes(
        val.utcOffset
      );
      this.userStore.setSpinnerForStore(true);
        this.getCars();
        this.isShow = true;
      }
    });
  }
  showTimeZoneModal() {
    const config: ModalOptions = {
      backdrop: 'static',
      keyboard: false,
      animated: true,
      ignoreBackdropClick: true,
    };
    this.bsModalRef = this.modalService.show(TimezoneModalComponent, config);
    
  }
  openAddModal() {
    this.bsModalRef = this.modalService.show(AddorEditModalComponent,{class: 'modal-lg'});
    this.bsModalRef.content.event.subscribe((result: string) => {
      console.log(result);
      if (result == 'Ok') {
        this.userStore.setSpinnerForStore(true);
        this.getCars();
      }
    });
  }
  openEditModal(carId: number) {
    console.log(carId);
    const initialState = {
      carId: carId,
    };
    this.bsModalRef = this.modalService.show(AddorEditModalComponent, {
      initialState,
      class: 'modal-lg'
    });

    this.bsModalRef.content.event.subscribe((result: any) => {
      console.log(result);
      if (typeof result == 'string' && result == 'Ok') {
        this.userStore.setSpinnerForStore(true);
        this.getCars();
      }
    });
  }
  getCars() {
   this.carSubscription = this.carService.getCarsByUserId().subscribe({
      next: (res) => {
        console.log(res);
        this.cars = res;
        this.userStore.setSpinnerForStore(false);
      },
      error: (err) => {
        this.toast.add({ severity: 'error', summary: 'Error', detail: err });
        this.userStore.setSpinnerForStore(false);
      },
    });
  }
  getSeverity(status: boolean) {
    if (status) {
      return 'success';
    } else {
      return 'danger';
    }
  }

  openDeleteCarModal(id: number) {
    console.log(id);
    const initialState = {
      headerTitle: 'Delete Car',
      carId: id,
    };
    this.bsModalRef = this.modalService.show(DeleteModalComponent, {
      initialState,
    });

    this.bsModalRef.content.event.subscribe((result: any) => {
      console.log(result);
      if (typeof result == 'string' && result == 'Ok') {
        this.userStore.setSpinnerForStore(true);
        this.getCars();
      }
    });
  }
}
