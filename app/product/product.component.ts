import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  stu=[
    {
      id:1,
      name:'mouse'
    }
  ];
  constructor() { }

  ngOnInit() {
  }

}
