using Admin_Tool.Models;
using Admin_tools.Models;
using Admin_Tool.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace  Admin_Tool.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AppUser userParam)
        {
            var user = _userService.Authenticate(userParam.Email, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(user);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody]AppUser userParam)
        {
            var user = _userService.Create(userParam.Email,userParam.Password,userParam.Telephone,userParam.FullName);

            if(user == null)
                return BadRequest(new {message = "Could not create new user"});

            if(!_userService.Save()) return StatusCode(StatusCodes.Status500InternalServerError);
            return Ok(user);
        }
    }
}