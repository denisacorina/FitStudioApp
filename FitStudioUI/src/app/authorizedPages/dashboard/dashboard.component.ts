import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { interval, take } from 'rxjs';
import { LoginComponent } from 'src/app/authentication/login/login.component';
import { RegistrationUserDTO } from 'src/app/interfaces/user/registrationUserDTO.model';
import { User } from 'src/app/interfaces/user/user.model';
import { AuthenticationService } from 'src/app/shared/services/authentication.service';
import { UsersService } from 'src/app/shared/services/users.service';
import { EmployeesService } from 'src/app/shared/services/employees.service';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],

})
export class DashboardComponent {
  public isUserAuthenticated: boolean = false;
  user!: any;
  display!: any;
  employee!: any;
  class!: any;
  trainer!: any;
  mondayClass!: any;
  tuesdayClass!: any;
  wednesdayClass!: any;
  users!: any;

  constructor(private authService: AuthenticationService, private userService: UsersService, private employeeService: EmployeesService, private router: Router) { }

  

  ngOnInit(): void {
    this.display = sessionStorage.getItem('loggedUser');
   this.usersList();
   this.employeesList();
   this.classesList();
   this.classesAndTrainersList();
   this.classesMonday();
   this.classesTuesday()
   this.classesWednesday();



  }




  usersList() {
    this.userService.getUsers().pipe(take(1)).subscribe((res) => {
      this.users = res;
    })
  }



  employeesList() { 
    this.employeeService.getEmployees().subscribe((res) => {
      this.employee = res;
    })
  }

classesAndTrainersList() { 
    this.employeeService.getTrainersAndClasses().subscribe((res) => {
      this.trainer = res;
    })
  }

  classesMonday() {
    this.employeeService.getClassesMonday().subscribe((res) => {
      this.mondayClass = res;
    })
  }

  classesTuesday() {
    this.employeeService.getClassesTuesday().subscribe((res) => {
      this.tuesdayClass = res;
    })
  }

  classesWednesday() {
    this.employeeService.getClassesWednesday().subscribe((res) => {
      this.wednesdayClass = res;
    })
  }

  classesList() { 
    this.employeeService.getClasses().subscribe((res) => {
      this.class = res;
    })
  }

  public logout = () => {
    this.authService.logout();
    this.router.navigateByUrl("home");
    
  }

  

  
}
