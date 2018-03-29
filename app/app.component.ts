import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular';
  obj={
    id:"1",
    name:"Mouse"
  }

  arr = ["abc", "def","ghi","ijk"];

  isTrue= true;

  isFalse=false;

  name="Micky";
}
