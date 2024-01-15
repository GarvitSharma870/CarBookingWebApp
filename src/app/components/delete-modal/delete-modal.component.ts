import { Component, EventEmitter } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { MessageService } from 'primeng/api';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-delete-modal',
  templateUrl: './delete-modal.component.html',
  styleUrls: ['./delete-modal.component.css'],
})
export class DeleteModalComponent {
  headerTitle: string = '';
  carId: number = 0;
  event: EventEmitter<any> = new EventEmitter();
  constructor(
    private toast: MessageService,
    private carService: CarService,
    private bsModalRef: BsModalRef
  ) {}

  onClose() {
    this.bsModalRef.hide();
  }
  deleteCar(id: number) {
    this.carService.deleteCar(id).subscribe({
      next:() => {
      this.event.emit('Ok');
      this.onClose();
      this.toast.add({
        severity: 'success',
        summary: 'SUCCESS',
        detail: 'Car Deleted Successfully',
      });
    },
    error: (err)=>{
      this.onClose();
      this.toast.add({
        severity: 'error',
        summary: 'ERROR',
        detail: err,
      });
    }
  });
  }
}
