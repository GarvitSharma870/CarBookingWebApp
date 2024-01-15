import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { CarBookingDTO } from '../interfaces/carBookingDTO';
import { DateConverterService } from './date-converter.service';
import { CarBooking } from '../interfaces/carBooking';

@Injectable({
  providedIn: 'root'
})
export class CarBookingService {

  private baseUrl: string = "https://localhost:7071/api/Booking/";
  constructor(private dateConverterService:DateConverterService,private http: HttpClient, private router: Router) { }


  getBookings(){
    return this.http.get<CarBooking[]>(`${this.baseUrl}GetBookings`);
  }
  getBookingsByUserId(){
    return this.http.get<CarBooking[]>(`${this.baseUrl}GetBookingsByUserId`);
  }
  bookCar(data:CarBookingDTO, offset:number){
    data.offset = offset;
    for(let i=0;i<data.bookedDuration.length;i++){
      data.bookedDuration[i] = new Date(this.dateConverterService.convertLocalDateForBackend(data.bookedDuration[i]));
    }
    return this.http.post<any>(this.baseUrl+'BookCar', data);
    
  }
  

}
