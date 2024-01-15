import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserStoreService {
  
  private name$= new BehaviorSubject<string>("");
  private role$ = new BehaviorSubject<string>("");
  private id$ = new BehaviorSubject<string>("");
  private timeZone$ = new BehaviorSubject<any>("");
  private spinner$ = new BehaviorSubject<boolean>(false);
  constructor() { }

  public getNameFromStore(){
    return this.name$.asObservable();
  }
  public setNameForStore(name: string){
    this.name$.next(name);
  }
  public getRoleFromStore(){
    return this.role$.asObservable();
  }
  public setRoleForStore(role: string){
    this.role$.next(role);
  }
  public setIdForStore(id: string){
    this.id$.next(id);
  }
  public getIdFromStore(){
    return this.id$.asObservable();
  }
  public setTimezoneForStore(id: string){
    this.timeZone$.next(id);
  }
  public getTimezoneFromStore(){
    return this.timeZone$.asObservable();
  }
  public setSpinnerForStore(value: boolean){
    this.spinner$.next(value);
  }
  public getSpinnerFromStore(){
    return this.spinner$.asObservable();
  }
}
