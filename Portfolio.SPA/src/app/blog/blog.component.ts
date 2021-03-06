import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit {

  blog: any;

  constructor(private Http: HttpClient) { }

  ngOnInit() {
    this.getBlog();
  }

  getBlog() {
    this.Http.get('http://localhost:5000/api/blog').subscribe(response => {
      this.blog = response;
    }, error => {
      console.log(error);
    });
  }
}
