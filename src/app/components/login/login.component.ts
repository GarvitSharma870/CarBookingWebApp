import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { UserStoreService } from 'src/app/services/user-store.service';
import ValidateForm from '../helpers/validateForm';
import { MessageService } from 'primeng/api';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm!: FormGroup;
  constructor(private fb: FormBuilder, private auth: AuthService, private router: Router, private userStore: UserStoreService,
    private toast: MessageService){}
  ngOnInit(): void {
    this.initializeLoginForm();
  }
  get f(){
    return this.loginForm.controls;
  }

  // Initialize Login Form Function
  initializeLoginForm(){
    this.loginForm = this.fb.group({
      email: new FormControl('',[Validators.required, Validators.email, Validators.pattern("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$")]),
      password: new FormControl('',[Validators.required, Validators.minLength(8), Validators.pattern("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\\s).{8,15}$")]),
    });
  }
  onLogin(){
    if(this.loginForm.valid){
      this.auth.login(this.loginForm.value).subscribe({
        next:(res=>{
          this.loginForm.reset();

          // Calling Decode Token Function
          this.decodeToken(res.token);

          this.toast.add({ severity: 'success', summary: 'Success', detail: res.message });
          this.router.navigate(['/'])
        }),
        error: (err=>{
          this.toast.add({ severity: 'error', summary: 'Error', detail: err });
        })
      })
    }
    else{
      ValidateForm.validateAllFormFields(this.loginForm);
    }
  }

  // Token Decoding Function
  decodeToken(token : string){
    this.auth.storeToken(token);
    const userPayload = this.auth.decodeToken();
    this.userStore.setNameForStore(userPayload.name);
    this.userStore.setRoleForStore(userPayload.role);
    this.userStore.setIdForStore(userPayload.nameidentifier);
  }
}
