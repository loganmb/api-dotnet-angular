import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  registerMode = false;
  
  //comunicação parent and child
  //users: any; 

  //comunicação parent and child
  //constructor(private http: HttpClient) { }
  constructor(public accountService: AccountService) { }

  ngOnInit(): void {
  }


  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  //comunicação parent-child
  // getUsers() { 
  //   this.http.get('https://localhost:5001/api/users').subscribe(users => this.users = users);
  // }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }


}
