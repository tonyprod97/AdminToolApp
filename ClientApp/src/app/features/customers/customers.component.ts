import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../../models/customer';
import { TableData } from '../../helpers/table-data';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent extends TableData {
  customers: Customer[];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    super();
    this.columnNames = ['Email', 'First Name', 'Last Name', 'Phone', 'Company Name', 'Language'];
    this.propsName = ['email', 'firstName', 'lastName', 'phone', 'companyName', 'lang'];
    this.apiUrl = 'api/customer';
  }

  onGetCustomers() {
    this.http.get<Customer[]>(this.baseUrl + this.apiUrl).subscribe(result => {
      this.customers = result;
    }, error => console.error(error));
  }

  onUpdateCustomer(newCustomer: any) {
    this.http.put(this.baseUrl + this.apiUrl + '/' + newCustomer.idCustomer, newCustomer)
      .subscribe(res => console.log('response: ', res));
  }
}
