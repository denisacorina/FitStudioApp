import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RegistrationUserDTO } from 'src/app/interfaces/user/registrationUserDTO.model';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  baseUrl = "https://localhost:7025/api/Accounts/"
  constructor(private http : HttpClient) { }

  register(model : RegistrationUserDTO)
  {
    return this.http.post(`${this.baseUrl}Registration`, model);
  }

}
