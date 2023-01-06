import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { RegistrationUserDTO } from 'src/app/interfaces/user/registrationUserDTO.model';
import { AuthenticationService } from 'src/app/shared/services/authentication.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  public isUserAuthenticated: boolean = false;
  users: any = [];
display!: any;
  constructor(private authService: AuthenticationService, private router: Router) { }

  ngOnInit(): void {
    this.usersList();
    this.display = sessionStorage.getItem('loggedUser');

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

  public get =()  => {
    this.authService.getUsers()
    .subscribe(res => {
      this.users.email = res;
    })
  }
}
