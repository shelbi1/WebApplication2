using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;
using WebApplication2.Models.ViewModels;
using WebApplication2.Models.ViewModels.OrderViewModels; 

/// <summary>
/// Принять запрос и передать в обработку 
/// </summary>

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
        public IActionResult GetById(GetByIdOrderViewModel orderModel)
        {
            if (orderModel.Id == Guid.Empty) return BadRequest();
            var user = _orderService.GetById(orderModel);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Save(CreateOrderViewModel orderModel)
        {
            var isSuccess = _orderService.Save(orderModel);
            return Ok(isSuccess);
        }

        [HttpPut]
        public IActionResult Edit(EditOrderViewModel orderModel)
        {
            var isSuccess = _orderService.Edit(orderModel);
            return Ok(isSuccess);
        }

        [HttpDelete]
        public IActionResult Delete(DeleteOrderViewModel orderModel)
        {
            var isSuccess = _orderService.Delete(orderModel);
            return Ok(isSuccess);
        }

        [HttpGet]
        public IActionResult GetOrdersByCreator(GetOrdersByCreator orderModel)
        {
            var isSuccess = _orderService.GetOrdersByCreator(orderModel);
            return Ok(isSuccess);
        }
    }
}
