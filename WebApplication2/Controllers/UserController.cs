using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var listUser = _userService.GetAll();
            return Ok(listUser);
        }
       
        [HttpGet]
        public IActionResult GetById(Guid id = default)
        {
            if (id == Guid.Empty) return BadRequest();
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Save(User user)
        {
            var isSuccess = _userService.Save(user);
            return Ok(isSuccess);
        }

        [HttpPut]
        public IActionResult Edit(User user)
        {
            var isSuccess = _userService.Edit(user);
            return Ok(isSuccess);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var isSuccess = _userService.Delete(id);
            return Ok(isSuccess);
        }
    }
}
