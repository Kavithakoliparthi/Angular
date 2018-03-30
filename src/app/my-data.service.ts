import { Injectable } from '@angular/core';

@Injectable()
export class MyDataService {

  constructor() { }
  obj={
    id:"1",
    name:"abc"
 }
  success(){
    return "successful";
  }

}
