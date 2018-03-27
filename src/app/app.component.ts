import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  templateUrl: 'app/app.component.html',
})
export class AppComponent  
{
     name = 'Angular2!';

     messageText = '';  
     onClickMe() 
     {  
        this.messageText = "Hi DataBinding!";  
      }

     names = 'C# Corner';  
     welcomeText = 'Welcome Angular2!'  
}
