import { Component } from '@angular/core';

@Component({
    selector: 'my-employee',
    templateUrl:'app/employee/employee.component.html',
})
export class EmployeeComponent
{
    name : string = 'kavitha';
    gender : string = 'female';
    age : number = 22;
}