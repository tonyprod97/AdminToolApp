import {CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router} from '@angular/router';
import { Injectable } from '@angular/core';
import { AuthService } from './auth.service';

@Injectable()

export class AuthGuardAdminService implements CanActivate {
    constructor(private router: Router) { }
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
      const user = JSON.parse(localStorage.getItem('currentUser'));
      if(user['isAdmin']) return true;

      this.router.navigate(['/log_in'], { queryParams: { returnUrl: state.url }});
      return false;
    }
}
