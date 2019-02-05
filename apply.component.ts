import { Component, OnInit } from '@angular/core';
import {ServiceService} from'../service.service';
import {student} from '../student';
import {NgForm} from '@angular/forms';
  import { from } from 'rxjs';
import { ImplicitReceiver } from '@angular/compiler';
import { Alert } from 'selenium-webdriver';
@Component({
  selector: 'app-apply',
  templateUrl: './apply.component.html',
  styleUrls: ['./apply.component.css']
})
export class ApplyComponent implements OnInit {
  student=new student();
  error='';
  isRegistered=false;


  constructor(private applyService:ServiceService) { }

  ngOnInit() {
  }
      Register(f:NgForm)
      {
        this.applyService.store(this.student).subscribe(
          data=>{this.isRegistered=true;
          console.log("registration successfull");
        f.reset
      },
      (err) =>{this.isRegistered=false;
      console.log("registration not successfull");}
      );
      }
    
  }


