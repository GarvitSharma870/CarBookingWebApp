import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { MessageService } from 'primeng/api';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { UserStoreService } from '../services/user-store.service';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {

  constructor(private toast: MessageService,private auth: AuthService, private router: Router, private userStore: UserStoreService) {}
  private jwtHelper = new JwtHelperService();
  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const token = this.auth.getToken();
    if(!this.jwtHelper.isTokenExpired(token)){
      request = request.clone({
        setHeaders: {Authorization: "Bearer "+token}
      });
    }
    return next.handle(request).pipe(
      catchError((err:any)=>{
        console.log(err)
        if(err instanceof HttpErrorResponse){
          if(err.status === 401){
            console.log('inside 401')
            this.toast.add({ severity: 'error', summary: 'Error', detail: "Session Timeout! Login again" });
            localStorage.clear();
            this.router.navigate(['/login']);
            this.userStore.setIdForStore("");
            this.userStore.setNameForStore("");
            this.userStore.setRoleForStore("");
            this.userStore.setSpinnerForStore(false);
            return throwError(()=> new Error(err?.error?.message || "Please login first"));
          }
        }
        return throwError(()=> new Error(err?.error.message));
      })
    );
  }
}
