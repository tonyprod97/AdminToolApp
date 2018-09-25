import { Maintenance } from './../../models/maintenance';
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TableData } from '../../helpers/table-data';

@Component({
  selector: 'app-maintenance',
  templateUrl: './maintenance.component.html',
  styleUrls: ['./maintenance.component.css']
})
export class MaintenanceComponent extends TableData {
  maintenanceData: Maintenance[] = [];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    super();
    this.apiUrl = 'api/Maintenance';
    this.columnNames = ['Order Number', 'Customer Id', 'Product Id', 'Email', 'License Key', 'Invoice Id',
    'Maintenance Date', 'Price', 'Currency', 'Licenses Extended', 'Version'];
    this.propsName = ['orderNr', 'idCustomer', 'productId', 'email', 'licenseKey', 'invoiceId', 'maintenanceDate',
    'price', 'currency', 'licensesExtended', 'version'];
  }

  onGetMaintenanceData() {
    this.http.get<Maintenance[]>(this.baseUrl + this.apiUrl).subscribe(result => {
      this.maintenanceData = result;
    }, error => console.error(error));
  }

  onUpdateMaintenanceData(newMaintenance: Maintenance) {
    this.http.put(this.baseUrl + this.apiUrl + '/' + newMaintenance.orderNr, newMaintenance)
      .subscribe(res => console.log('response:', res));
  }
}
