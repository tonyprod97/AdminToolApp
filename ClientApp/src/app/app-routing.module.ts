import { AuthGuardAdminService } from './services/auth-guard-admin.service';
import { CreateUsersComponent } from './authentication/create-users/create-users.component';
import { AuthGuardService } from './services/auth-guard.service.';
import { NgModule } from '@angular/core';
import { RouterModule, CanActivate } from '@angular/router';

import { LicensesComponent } from './features/licenses/licenses.component';
import { CustomersComponent } from './features/customers/customers.component';
import { InstalledLicensesComponent } from './features/installed-licenses/installed-licenses.component';
import { LicenseFormComponent } from './features/license-form/license-form.component';
import { MaintenanceComponent } from './features/maintenance/maintenance.component';
import { LogInComponent } from './authentication/log-in/log-in.component';


const appRoutes = [
  { path: 'customers', component: CustomersComponent, canActivate: [AuthGuardService] },
  { path: 'licenses', component: LicensesComponent, canActivate: [AuthGuardService] },
  { path: 'installed_licenses', component: InstalledLicensesComponent, canActivate: [AuthGuardService] },
  { path: 'create_licence', component: LicenseFormComponent, canActivate: [AuthGuardService] },
  {path: 'maintenance', component: MaintenanceComponent, canActivate: [AuthGuardService]},
  {path: 'log_in', component: LogInComponent},
  {path: 'create_users', component: CreateUsersComponent, canActivate: [AuthGuardAdminService]},
  { path: '', component: CustomersComponent, pathMatch: 'full' , canActivate: [AuthGuardService]}
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
  providers: [AuthGuardService,AuthGuardAdminService],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
