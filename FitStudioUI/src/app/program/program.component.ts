import { Component } from '@angular/core';
import { take } from 'rxjs';
import { EmployeesService } from '../shared/services/employees.service';

@Component({
  selector: 'app-program',
  templateUrl: './program.component.html',
  styleUrls: ['./program.component.css']
})
export class ProgramComponent {
  mondayClass!: any;
  tuesdayClass!: any;
  wednesdayClass!: any;
  constructor(private employeeService: EmployeesService) { }

  ngOnInit(): void {
  
   this.classesMonday();
   this.classesTuesday()
   this.classesWednesday();

}


classesMonday() {
  this.employeeService.getClassesMonday().pipe(take(1)).subscribe((res) => {
    this.mondayClass = res;
  })
}

classesTuesday() {
  this.employeeService.getClassesTuesday().pipe(take(1)).subscribe((res) => {
    this.tuesdayClass = res;
  })
}

classesWednesday() {
  this.employeeService.getClassesWednesday().pipe(take(1)).subscribe((res) => {
    this.wednesdayClass = res;
  })
}


}
