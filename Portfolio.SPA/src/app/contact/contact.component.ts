import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  email: any;

  constructor(private Http: HttpClient) { }

  ngOnInit() {
    this.getEmail();
  }

  getEmail() {
   this.Http.get('http://localhost:5000/api/email').subscribe(response => {
     this.email = response;
   }, error => {
     console.log(error);
   });
  }

}
