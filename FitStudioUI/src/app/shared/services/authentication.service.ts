import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RegistrationUserDTO } from 'src/app/interfaces/user/registrationUserDTO.model';
import { AuthenticationDTO } from 'src/app/interfaces/user/authenticateUser.model';
import { AuthResponseDto } from 'src/app/interfaces/response/authResponseDTO.model';
import { Observable, Subject } from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';
import { TitleStrategy } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  baseUrl = "https://localhost:7025/api/Accounts/";


  private authChangeSub = new Subject<boolean>()
  public authChanged = this.authChangeSub.asObservable();


  constructor(private http : HttpClient, private jwtHelper: JwtHelperService) { }

  register(model : RegistrationUserDTO)
  {
    return this.http.post(`${this.baseUrl}Registration`, model);
  }

  login(model: AuthenticationDTO)
  {
    return this.http.post<AuthResponseDto>(`${this.baseUrl}Login`, model);
  }

  logout = () => {
    localStorage.removeItem("token");
    this.sendAuthStateChangeNotification(false);
  }

  sendAuthStateChangeNotification = (isAuthenticated: boolean) => {
    this.authChangeSub.next(isAuthenticated);
  }

  isUserAuthenticated = (): any => {
    const token = localStorage.getItem("token");
    return token && !this.jwtHelper.isTokenExpired(token);
  }

  getUsers(){
    return this.http.get("https://localhost:7025/api/Users/usersList");
  }
}
