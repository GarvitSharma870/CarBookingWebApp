import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { UserStoreService } from 'src/app/services/user-store.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class HeaderComponent implements OnInit, OnDestroy {
  public timezone: any;
  public name: string = '';
  public timeZone: string = '';
  
  nameSubscription!: Subscription;
  timezoneSubscription!: Subscription
  constructor(private auth: AuthService, private userStore: UserStoreService) {}
  ngOnInit(): void {
    this.nameSubscription = this.userStore.getNameFromStore().subscribe((val) => {
      console.log(val);
      const nameFromToken = this.auth.getNameFromToken();
      this.name = val || nameFromToken;
    });
    this.timezoneSubscription = this.userStore.getTimezoneFromStore().subscribe((val) => {
      console.log(val);
      this.timeZone = val.timeZoneName;
    });
  }

  ngOnDestroy(): void {
    this.nameSubscription.unsubscribe();
    this.timezoneSubscription.unsubscribe();
  }
  signout() {
    console.log('inside signout');
    this.auth.signout();
    this.userStore.setNameForStore('');
    this.userStore.setRoleForStore('');
    this.userStore.setIdForStore('');
    this.userStore.setTimezoneForStore('');
  }
  
}
