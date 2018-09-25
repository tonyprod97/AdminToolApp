import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-license-form',
  templateUrl: './license-form.component.html',
  styleUrls: ['./license-form.component.css']
})
export class LicenseFormComponent implements OnInit {

    form: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      licenseKey: new FormControl('', Validators.required),
      usedLicenses: new FormControl('', [Validators.pattern(/^-?(0|[1-9]\d*)?$/), Validators.required]),
      totalLicenses: new FormControl('', [Validators.pattern(/^-?(0|[1-9]\d*)?$/), Validators.required]),
      version: new FormControl('', [Validators.pattern(/^-?(0|[1-9]\d*)?$/), Validators.required]),
      validUntil: new FormControl(''),
      active: new FormControl(''),
      numExpired: new FormControl('', Validators.pattern(/^-?(0|[1-9]\d*)?$/)),
      canExtendUntil: new FormControl(''),
      idCustomer: new FormControl('', Validators.required)

    });
  }


  onSubmit() {
    console.log(this.form);
    this.form.reset();
  }
}
