import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  user:any;
  check:boolean=true;
  constructor() { 
    
    this.user={Name:'Ammu Chandy Andrews',
  Job:'Student',
  Address:'Kaipuzha house',
   phno:[]};
  }
  togglecheck()
  {
    this.check=!this.check;
  }

  ngOnInit() {
  }

}
