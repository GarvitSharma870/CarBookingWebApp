import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { CarComponent } from './components/car/car.component';
import { RegisterComponent } from './components/register/register.component';
import { authGuard } from './guards/auth.guard';
import { AddBookingComponent } from './components/add-booking/add-booking.component';
import { CarBookingComponent } from './components/car-booking/car-booking.component';

const routes: Routes = [
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'signup',
    component: RegisterComponent
  },
  {
    path: '',
    component: CarComponent,
    canActivate: [authGuard]
  },
  {
    path: 'car-bookings',
    component: CarBookingComponent,
    canActivate: [authGuard]
  },
  {
    path: 'car-book',
    component: AddBookingComponent,
    canActivate: [authGuard]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
  
 }
