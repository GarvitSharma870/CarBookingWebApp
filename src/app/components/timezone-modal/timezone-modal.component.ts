import { Component, EventEmitter, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { CarService } from 'src/app/services/car.service';
import { UserStoreService } from 'src/app/services/user-store.service';

@Component({
  selector: 'app-timezone-modal',
  templateUrl: './timezone-modal.component.html',
  styleUrls: ['./timezone-modal.component.css']
})
export class TimezoneModalComponent implements OnInit {
  timeZones:any;
  public selectedTimeZone: any;
constructor(private userStore: UserStoreService,private bsModalRef: BsModalRef,private apiService: CarService){}
ngOnInit(){
  this.userStore.setSpinnerForStore(true);
  this.getTimeZones();
}

getTimeZones(){
  this.apiService.getTimeZones().subscribe(val=>{
    this.timeZones = val;
    this.userStore.setSpinnerForStore(false);
  })
}
getData(){
  this.userStore.setTimezoneForStore(this.selectedTimeZone);
  this.bsModalRef.hide();  
}

}
