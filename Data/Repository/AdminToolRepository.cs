using Admin_Tool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_Tool.Data.Repository
{
    public class AdminToolRepository: IAdminToolRepository
    {
        private readonly AdminToolContext _context;

        public AdminToolRepository(AdminToolContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomers()
        {
             return _context.Customer;
        }

        public IEnumerable<TcoinstallLog> GetInstalledLicenses()
        {
            return _context.TcoinstallLog;
        }

        public IEnumerable<Licenses> GetLicenses()
        {
            return _context.Licenses;
        }

        public IEnumerable<Maintenance> GetMaintainceData()
        {
            return _context.Maintenance;
        }

        public bool Save()
        {
            return _context.SaveChanges() > -1;
        }

        public Customer UpdateCustomer(Customer newCustomer)
        {
            _context.Customer.Update(newCustomer);

            return newCustomer;
        }

        public TcoinstallLog UpdateInstalledLicense(TcoinstallLog newLicense)
        {
            _context.TcoinstallLog.Update(newLicense);

            return newLicense;
        }

        public TcoinstallLog UpdateInstalledLicense(Maintenance data)
        {
            throw new NotImplementedException();
        }

        public Licenses UpdateLicense(Licenses newLicense)
        {
            _context.Licenses.Update(newLicense);

            return newLicense;
        }

        public Maintenance UpdateMaintainceData(Maintenance data)
        {
            _context.Maintenance.Update(data);

            return data;
        }
    }
}
