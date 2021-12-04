using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var listOrder = _orderService.GetAll();
            return Ok(listOrder);
        }

        [HttpGet]
        public IActionResult GetById(Guid id = default)
        {
            if (id == Guid.Empty) return BadRequest();
            var user = _orderService.GetById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Save(Order order)
        {
            var isSuccess = _orderService.Save(order);
            return Ok(isSuccess);
        }

        [HttpPut]
        public IActionResult Edit(Order order)
        {
            var isSuccess = _orderService.Edit(order);
            return Ok(isSuccess);
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var isSuccess = _orderService.Delete(id);
            return Ok(isSuccess);
        }
    }
}
