import { User } from './../../models/user';
import { AuthService } from './../../services/auth.service';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-users',
  templateUrl: './create-users.component.html',
  styleUrls: ['./create-users.component.css']
})
export class CreateUsersComponent implements OnInit {
  form: FormGroup;

  constructor(private formBuilder: FormBuilder,private authService: AuthService) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      email: new FormControl('', [Validators.required,Validators.email]),
      password: new FormControl('', Validators.required),
      fullName: new FormControl(''),
      telephone: new FormControl(''),
    });
  }

  onSubmit(){
    const errorMessage = `User with email ${this.form.controls.email.value} already exists.`;
    this.authService.createUser(this.form.controls.email.value, this.form.controls.password.value,
      this.form.controls.telephone.value, this.form.controls.fullName.value).first()
                      .subscribe(data => this.form.reset(),
                                  error => alert(errorMessage);
  }
}
