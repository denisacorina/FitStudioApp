import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class UsersService {

  baseUrl = "https://localhost:7267/api/Users";


  constructor(private http : HttpClient) { }

  getUsers(){
    return this.http.get(this.baseUrl);
  }

}
