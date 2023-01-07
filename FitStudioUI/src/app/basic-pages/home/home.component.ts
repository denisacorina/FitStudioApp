import { Component } from '@angular/core';
import { ViewEncapsulation } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  encapsulation: ViewEncapsulation.None,
})
export class HomeComponent {

 
  constructor( private router: Router, private route: ActivatedRoute) { }
  
  navigateToLogin()
  {
    this.router.navigateByUrl("login");
  }

  navigateToRegister()
  {
    this.router.navigateByUrl("register");
  }
  


}
