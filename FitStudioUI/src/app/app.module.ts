import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor, JwtModule } from "@auth0/angular-jwt";
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RegisterComponent } from './authentication/register/register.component';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './authentication/login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './basic-pages/home/home.component';
import { MaterialModule } from './shared/modules/material/material.module';
import { DashboardComponent } from './authorizedPages/dashboard/dashboard.component';
import { FooterComponent } from './basic-pages/footer/footer.component';
import { PricesComponent } from './prices/prices.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { ProgramComponent } from './program/program.component';




export function tokenGetter()
{
  return localStorage.getItem("token");
}

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    HomeComponent,
    DashboardComponent,
    FooterComponent,
    PricesComponent,
    NavBarComponent,
    ProgramComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MaterialModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ["localhost:5001"],
        disallowedRoutes: []
      }
    })
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: JwtInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }