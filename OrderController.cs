using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Entities;
using Repositary.Services;


namespace Fertilizer.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _service = new OrderService();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAllOrders());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_service.GetOrderById(id));

        [HttpPost]
        public IActionResult Add(Order order)
        {
            _service.AddOrder(order);
            return Ok("Order Added");
        }

        [HttpPut]
        public IActionResult Update(Order order)
        {
            _service.UpdateOrder(order);
            return Ok("Order Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteOrder(id);
            return Ok("Order Deleted");
        }
    }
}

