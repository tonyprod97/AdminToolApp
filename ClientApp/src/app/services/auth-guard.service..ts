import {CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router} from '@angular/router';
import { Injectable } from '@angular/core';

@Injectable()

export class AuthGuardService implements CanActivate {
    constructor(private router: Router) { }
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
      console.log('authservice XXXXXXX');
        if (localStorage.getItem('currentUser')) {
            return true;
        }

        this.router.navigate(['/log_in'], { queryParams: { returnUrl: state.url }});
        return false;
    }
}
