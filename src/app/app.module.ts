import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { CarComponent } from './components/car/car.component';
import { CarBookingComponent } from './components/car-booking/car-booking.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MessageService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
import { HeaderComponent } from './components/header/header.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { TableModule } from 'primeng/table';
import { TagModule } from 'primeng/tag';
import { AddorEditModalComponent } from './components/addor-edit-modal/addor-edit-modal.component';
import { BsModalService, ModalModule } from 'ngx-bootstrap/modal';
import { InputNumberModule } from 'primeng/inputnumber';
import { CalendarModule } from 'primeng/calendar';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { DropdownModule } from 'primeng/dropdown';
import { TokenInterceptor } from './interceptors/token.interceptor';
import { TimezoneModalComponent } from './components/timezone-modal/timezone-modal.component';
import { AddBookingComponent } from './components/add-booking/add-booking.component';
import { ChipModule } from 'primeng/chip';
import { DeleteModalComponent } from './components/delete-modal/delete-modal.component';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    CarComponent,
    CarBookingComponent,
    HeaderComponent,
    AddorEditModalComponent,
    TimezoneModalComponent,
    AddBookingComponent,
    DeleteModalComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastModule,
    FormsModule,
    ReactiveFormsModule,
    ButtonModule,
    InputTextModule,
    TableModule,
    TagModule,
    ModalModule,
    InputNumberModule,
    CalendarModule,
    DropdownModule,
    ChipModule,
    ProgressSpinnerModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptor,
      multi: true,
    },
    MessageService,
    BsModalService,
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
