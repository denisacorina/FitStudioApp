import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { HttpErrorResponse } from '@angular/common/http';
import { RegistrationUserDTO } from 'src/app/interfaces/user/registrationUserDTO.model';
import { AuthenticationService } from 'src/app/shared/services/authentication.service';
import { Router, UrlSerializer } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})


export class RegisterComponent {
 
  registerForm!: FormGroup;

  constructor(private authService: AuthenticationService, private router : Router) {}

  ngOnInit(): void {
    this.registerForm = new FormGroup({
      firstName: new FormControl(''),
      lastName: new FormControl(''),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required])
    });
  }

  public validateControl = (controlName: string) => {
    return this.registerForm.get(controlName)?.invalid && this.registerForm.get(controlName)?.touched
  }
  public hasError = (controlName: string, errorName: string) => {
    return this.registerForm.get(controlName)?.hasError(errorName)
  }

public registerUser = (registerFormValue: any) => {
  const formValues = { ...registerFormValue };
  const user: RegistrationUserDTO = {
    firstName: formValues.firstName,
    lastName: formValues.lastName,
    email: formValues.email,
    password: formValues.password
  };
  this.authService.register(user)
  .subscribe({
    next: (_) =>{ console.log("Successful registration");
    this.router.navigateByUrl("login");
  },
    error: (err: HttpErrorResponse) => console.log(err.error.errors)
  })
}
}