using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin_Tool.Data.Repository;
using Admin_Tool.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Tool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private readonly IAdminToolRepository _repository;

        public LicenseController(IAdminToolRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Get()
        {
            var licenses = _repository.GetLicenses();

            if (licenses != null) return Ok(licenses);

            return NotFound();
        }

        [HttpPut("{key}")]
        public IActionResult Put([FromBody]Licenses license)
        {
            var newLicense = _repository.UpdateLicense(license);

            if (newLicense == null) return NotFound();

            _repository.Save();

            return Ok(newLicense);
        }

    }
}