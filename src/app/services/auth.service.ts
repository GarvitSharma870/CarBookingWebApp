import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { RegisterDTO } from '../interfaces/registerDTO';
import { LoginDTO } from '../interfaces/loginDTO';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private baseUrl: string = "https://localhost:7071/api/Account/";
  private userPayload: any
  constructor(private http: HttpClient, private router: Router) { 
    this.userPayload = this.decodeToken();
  }
  signup(userObj: RegisterDTO){
    return this.http.post<any>(`${this.baseUrl}Register`,userObj);
  }
  login(loginObj: LoginDTO){
    return this.http.post<any>(`${this.baseUrl}Login`,loginObj);
  }
  signout(){
    localStorage.clear();
    this.userPayload = null;
    this.router.navigate(['/login']);
  }
  storeToken(tokenValue: string){
    localStorage.setItem('token',tokenValue);
  }
  getToken(){
    return localStorage.getItem('token');
  }
  isLoggedIn(): boolean{
    return !!localStorage.getItem('token');
  }
  decodeToken(){
    const jwtHelper = new JwtHelperService();
    const token = this.getToken()!;
    console.log(token)
    console.log(jwtHelper.decodeToken(token));
    return jwtHelper.decodeToken(token);
  }
  getNameFromToken(){
    if(this.userPayload){
      return this.userPayload.name;
    }
  }
  getRoleFromToken(){
    if(this.userPayload){
      return this.userPayload.role;
    }
  }
  getIdFromToken(){
    if(this.userPayload){
      return this.userPayload.nameidentifier;
    }
  }
}
