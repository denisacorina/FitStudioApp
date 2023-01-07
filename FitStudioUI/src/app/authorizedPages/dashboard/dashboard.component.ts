import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { interval } from 'rxjs';
import { LoginComponent } from 'src/app/authentication/login/login.component';
import { RegistrationUserDTO } from 'src/app/interfaces/user/registrationUserDTO.model';
import { AuthenticationService } from 'src/app/shared/services/authentication.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],
  //providers: [LoginComponent]
})
export class DashboardComponent {
  public isUserAuthenticated: boolean = false;
  users: any = [];
  display!: any;
  constructor(private authService: AuthenticationService, private router: Router /*, public loginComponent: LoginComponent*/) { }

  ngOnInit(): void {
    this.display = sessionStorage.getItem('loggedUser');
    this.usersList();
    

  }

  usersList() {
    this.authService.getUsers().subscribe(res => {
      this.users = res;
    })
  }

  public logout = () => {
    this.authService.logout();
    this.router.navigateByUrl("home");
    
  }

  public get = ()  => {
    this.authService.getUsers()
    .subscribe(res => {
      this.users.email = res;
    })
  }
}
