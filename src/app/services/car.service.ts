import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { DateConverterService } from './date-converter.service';
import { CarDTO } from '../interfaces/carDTO';
import { UserStoreService } from './user-store.service';
import { Car } from '../interfaces/car';

@Injectable({
  providedIn: 'root'
})
export class CarService {
  private baseUrl: string = "https://localhost:7071/api/Car/";
  private baseUrl2: string = "https://localhost:7071/api/Company/";
  private timezoneOffset:number = 0;
  constructor(private userStore: UserStoreService,private dateConverterService:DateConverterService,private http: HttpClient, private router: Router) { 
    this.getTimeZoneOffset();
  }

  getTimeZones(){
    return this.http.get(this.baseUrl+'GetAllTimeZones');
  }
  getCompanies(){
    return this.http.get<any>(`${this.baseUrl2}GetCompanies`);
  }
  getCars(){
    return this.http.get<Car[]>(`${this.baseUrl}GetCars`);
  }
  getCarsByUserId(){
    return this.http.get<Car[]>(`${this.baseUrl}GetCarByUserId`);
  }
  getCarsByCompanyId(id:number){
    return this.http.get<Car[]>(`${this.baseUrl}GetCarsByCompanyId/${id}`);
  }
  getCarById(id:number){
    return this.http.get<Car>(`${this.baseUrl}GetCarById/${id}`);
  }
  addCar(data:CarDTO){
    data.offset = this.timezoneOffset;
    for(let i=0;i<data.availableTime.length;i++){
      data.availableTime[i] = new Date(this.dateConverterService.convertLocalDateForBackend(data.availableTime[i]));
    }
    return this.http.post<any>(this.baseUrl+'Add', data);
    
  }
  editCar(data:CarDTO, id: number){
    data.offset = this.timezoneOffset;
    for(let i=0;i<data.availableTime.length;i++){
      data.availableTime[i] = new Date(this.dateConverterService.convertLocalDateForBackend(data.availableTime[i]));
    }
    return this.http.put<any>(this.baseUrl+'Update/'+id, data);  
  }
  deleteCar(id: number){
    return this.http.delete(`${this.baseUrl}Delete/${id}`);
  }

  getTimeZoneOffset(){
    this.userStore.getTimezoneFromStore().subscribe((val) => {
      this.timezoneOffset = this.dateConverterService.getOffSetInMinutes(
        val.utcOffset
      );
    });
  }
}
