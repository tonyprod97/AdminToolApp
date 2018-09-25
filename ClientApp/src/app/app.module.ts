import { AuthService } from './services/auth.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { TableCellComponent } from './table-cell/table-cell.component';
import { TableComponent } from './table/table.component';
import { LicensesComponent } from './features/licenses/licenses.component';
import { CustomersComponent } from './features/customers/customers.component';
import { InstalledLicensesComponent } from './features/installed-licenses/installed-licenses.component';
import { LicenseFormComponent } from './features/license-form/license-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { MaintenanceComponent } from './features/maintenance/maintenance.component';
import { AppRoutingModule } from './app-routing.module';
import { LogInComponent } from './authentication/log-in/log-in.component';
import { CreateUsersComponent } from './authentication/create-users/create-users.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    TableCellComponent,
    TableComponent,
    LicensesComponent,
    CustomersComponent,
    InstalledLicensesComponent,
    LicenseFormComponent,
    MaintenanceComponent,
    LogInComponent,
    CreateUsersComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
