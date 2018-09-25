using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin_Tool.Data.Repository;
using Admin_Tool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin_Tool.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        //private static List<TestData> TestValues = new List<TestData>();
        private readonly IAdminToolRepository _repository;

        public CustomerController(IAdminToolRepository repository)
        {
            _repository = repository;
        }
        
        public IActionResult Get()
        {
            var customers = _repository.GetCustomers();

            if (customers != null) return Ok(customers);

            return NotFound();
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromBody]Customer customer)
        {
            var newCustomer = _repository.UpdateCustomer(customer);

            if (newCustomer == null) return NotFound();

            _repository.Save();

            return Ok(newCustomer);
        }

    }
}
