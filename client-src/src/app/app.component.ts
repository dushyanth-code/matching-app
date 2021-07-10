import { Component } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'My App';
  users: any;
  constructor(private httpclient: HttpClient) {

    this.httpclient.get('https://localhost:44346/api/User').subscribe(response => {
      this.users = response;
    }, err => {
      console.log(err)
    });
  }
}
