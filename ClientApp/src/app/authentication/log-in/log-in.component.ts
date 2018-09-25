import { AuthService } from './../../services/auth.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import 'rxjs/add/operator/first';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {
  returnUrl: string;
  form: FormGroup;

  constructor(private formBuilder: FormBuilder, private authService: AuthService,
    private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      email: new FormControl('', [Validators.email, Validators.required]),
      password: new FormControl('', [Validators.required])
    });
    this.authService.logout();
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
  }

  onLogIn() {
    console.log(this.form.controls.email);
    this.authService.login(this.form.controls.email.value, this.form.controls.password.value).first()
                      .subscribe(data => this.router.navigate([this.returnUrl]),
                                  error => console.log(error));
  }
}
