import { Component } from '@angular/core';
import { MyDataService  } from './my-data.service';

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
  
  onSubmit=function(user)
  {
      console.log(user);
  }
  items=["Angular1","Angular 2","Angular 4","Angular 5","Angular JS"];
  newItem="";
  pushItem = function()
  {
    if(this.newItem != "")
    {
      this.items.push(this.newItem);
      this.newItem="";
    }
  }
  removeItem=function(index)
  {
      this.items.splice(index,1);
  }
  

  constructor(private newService:MyDataService){}
    ngOnInit()
    {
        console.log(this.newService.success())
        console.log(this.newService.obj)
    }
}
