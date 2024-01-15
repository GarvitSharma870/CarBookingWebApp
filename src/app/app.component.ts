import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { UserStoreService } from './services/user-store.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'CarBooking';
  public spinner:boolean = false;
  spinnerSubscription!: Subscription;
  constructor(private userStore: UserStoreService){}
  ngOnInit(): void {
    this.getSpinner();
  }
  ngOnDestroy(): void {
    this.spinnerSubscription.unsubscribe();
  }

  getSpinner(){
    this.spinnerSubscription = this.userStore.getSpinnerFromStore().subscribe(res=>{
      this.spinner = res;
  });
  }
}
