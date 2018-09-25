import { User } from './../models/user';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';
@Injectable()
export class AuthService {
  constructor(private http: HttpClient, private router: Router) { }

  isLoggedIn() {
    return localStorage.getItem('currentUser');
  }
  login(email: string, password: string) {
      return this.http.post<any>('/api/user/authenticate', { email: email, password: password })
          .map(user => {
              // login successful if there's a jwt token in the response
              if (user && user.token) {
                  // store user details and jwt token in local storage to keep user logged in between page refreshes
                  localStorage.setItem('currentUser', JSON.stringify(user));
              }

              return user;
          });
  }

  createUser( email:string, password:string, telephone:string,fullName: string) {
    return this.http.post<any>('api/user/create', { email: email, password: password,
                                                 telephone: telephone, fullName: fullName });
  }
  isAdmin() {
    const user = JSON.parse(localStorage.getItem('currentUser'));
    return user && user['token'] && user['isAdmin'];
  }
  logout() {
      // remove user from local storage to log user out
      localStorage.removeItem('currentUser');
  }
}
