import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MessageService } from 'primeng/api';
import { AuthService } from 'src/app/services/auth.service';
import ValidateForm, { ConfirmedValidator } from '../helpers/validateForm';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit{
  constructor(private toast: MessageService,private fb: FormBuilder, private auth: AuthService, private router: Router){}
  signupForm!: FormGroup;
  ngOnInit(): void {
   this.initializeSignUpForm();
  }

  // Get Form Controls
  get f(){
    return this.signupForm.controls;
  }

  // Intialize SignUp Form
  initializeSignUpForm(){
    this.signupForm = this.fb.group({
      name: new FormControl('',[Validators.required,Validators.minLength(3),Validators.maxLength(15),Validators.pattern("^[a-zA-z]+([\\s][a-zA-Z]+)*$")]),
      email: new FormControl('',[Validators.required, Validators.email, Validators.pattern("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$")]),
      password: new FormControl('',[Validators.required, Validators.minLength(8), Validators.pattern("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\\s).{8,15}$")]),
      confirmPassword: ['',Validators.required],
     },{ 
      validator: ConfirmedValidator('password', 'confirmPassword')
    })
  }
  onSignUp(){
    if(this.signupForm.valid){
      this.auth.signup(this.signupForm.value).subscribe({
        next:(res=>{
          this.signupForm.reset();
          this.toast.add({ severity: 'success', summary: 'Success', detail: res.message });
          this.router.navigate(['login']);
        }),
        error:(err=>{
          console.log('Error box');
          console.log(err);
          this.toast.add({ severity: 'error', summary: 'Error', detail: err });
        })
      })
    }
    else{
      ValidateForm.validateAllFormFields(this.signupForm);
    }
  }
}
