import { License } from './../../models/license';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TableData } from '../../helpers/table-data';

@Component({
  selector: 'app-licenses',
  templateUrl: './licenses.component.html',
  styleUrls: ['./licenses.component.css']
})
export class LicensesComponent extends TableData {
  licenses: License[] = [];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    super();
    this.apiUrl = 'api/license';
    this.columnNames = ['Used Licenses', 'Total Licenses', 'Version', 'Valid Until', 'Active', 'Number Expired', 'Can Extend Until'];
    this.propsName = ['usedLicenses', 'totalLicenses', 'version', 'validUntil', 'active', 'numExpired', 'canExtendUntil'];
  }

  onGetLicenses() {
    this.http.get<License[]>(this.baseUrl + this.apiUrl).subscribe(result => {
      this.licenses = result;
    }, error => console.error(error));
  }

  onUpdateLicenses(newLicense: any) {
    this.http.put(this.baseUrl + this.apiUrl + '/' + newLicense.licenseKey, newLicense)
      .subscribe(res => console.log('response:', res));
  }

}
