import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  baseUrl = "https://localhost:7267/api/";


  constructor(private http : HttpClient) { }

  getEmployees(){
    return this.http.get(`${this.baseUrl}Employees/`);
  }

  getClasses(){
    return this.http.get(`${this.baseUrl}Classes/`);
  }

  getTrainersAndClasses(){
    return this.http.get(`${this.baseUrl}Employees/trainers`);
  }

  getClassesMonday(){
    return this.http.get(`${this.baseUrl}Employees/trainers/monday`);
  }

  getClassesTuesday(){
    return this.http.get(`${this.baseUrl}Employees/trainers/tuesday`);
  }

  getClassesWednesday(){
    return this.http.get(`${this.baseUrl}Employees/trainers/wednesday`);
  }
}
