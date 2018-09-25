using Admin_Tool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_Tool.Data.Repository
{
    public interface IAdminToolRepository
    {
        IEnumerable<Customer> GetCustomers();
        bool Save();
        Customer UpdateCustomer(Customer newCustomer);

        IEnumerable<Licenses> GetLicenses();
        Licenses UpdateLicense(Licenses newLicense);
        IEnumerable<TcoinstallLog> GetInstalledLicenses();
        TcoinstallLog UpdateInstalledLicense(TcoinstallLog data);
        IEnumerable<Maintenance> GetMaintainceData();
        Maintenance UpdateMaintainceData(Maintenance data);
    }
}
