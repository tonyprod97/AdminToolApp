import { InstalledLicense } from './../../models/installed-license';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TableData } from '../../helpers/table-data';

@Component({
  selector: 'app-installed-licenses',
  templateUrl: './installed-licenses.component.html',
  styleUrls: ['./installed-licenses.component.css']
})
export class InstalledLicensesComponent extends TableData{
  licenses: InstalledLicense[];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    super();

    this.columnNames = ['Machine Name', 'Old Version', 'New Version', 'Installation Date', 'Email', 'Version Info'];
    this.propsName = ['machineName', 'oldVersion', 'newVersion', 'installedOn', 'email', 'versionInfo'];
    this.apiUrl = 'api/installedLicense';
  }

  onGetLicenses() {
    this.http.get<InstalledLicense[]>(this.baseUrl + this.apiUrl).subscribe(result => {
      this.licenses = result;
    }, error => console.error(error));
  }

  onUpdateLicenses(newLicense: any) {
    this.http.put(this.baseUrl + this.apiUrl + '/' + newLicense.upgradeId, newLicense)
      .subscribe(res => console.log('response: ', res));
  }

  onSubmit(val) {
    const validate = val.from && val.to && val.from !== '' && val.to !== '';
    console.log(validate,'----')
    this.licenses = this.licenses.filter(licence => {
      if (validate) {
        return licence.installedOn > val.from && licence.installedOn < val.to;
      }
    });
    if(!validate) this.onGetLicenses();
  }
}
