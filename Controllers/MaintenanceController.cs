using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin_Tool.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Admin_Tool.Models;


namespace Admin_Tool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly IAdminToolRepository _repository;

        public MaintenanceController(IAdminToolRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Get()
        {
            var data = _repository.GetMaintainceData();

            if (data != null) return Ok(data);

            return NotFound();
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromBody]Maintenance data)
        {
            var newData = _repository.UpdateMaintainceData(data);

            if (newData == null) return NotFound();

            _repository.Save();

            return Ok(newData);
        }
    }
}