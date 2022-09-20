using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;
using WebApplication2.Models.ViewModels.UserViewModel;

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
        public IActionResult GetById(GetByIdUser userModel)
        {
            if (userModel.Id == Guid.Empty) return BadRequest();
            var user = _userService.GetById(userModel);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(CreateUserViewModel userModel)
        {
            var isSuccess = _userService.Create(userModel);
            return Ok(isSuccess);
        }

        [HttpPut]
        public IActionResult Edit(EditUserViewModel userModel)
        {
            var isSuccess = _userService.Edit(userModel);
            return Ok(isSuccess);
        }

        [HttpDelete]
        public IActionResult Delete(DeleteUserViewModel userModel)
        {
            var isSuccess = _userService.Delete(userModel);
            return Ok(isSuccess);
        }
    }
}