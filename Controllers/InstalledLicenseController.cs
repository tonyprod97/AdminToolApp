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
    public class InstalledLicenseController : ControllerBase
    {
        private readonly IAdminToolRepository _repository;

        public InstalledLicenseController(IAdminToolRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Get()
        {
            var licenses = _repository.GetInstalledLicenses();

            if (licenses != null) return Ok(licenses);

            return NotFound();
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromBody]TcoinstallLog license)
        {
            var newLicense = _repository.UpdateInstalledLicense(license);

            if (newLicense == null) return NotFound();

            _repository.Save();

            return Ok(newLicense);
        }
    }
}