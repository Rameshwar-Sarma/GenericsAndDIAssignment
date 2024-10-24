using ECommerceAPI.Models;
using ECommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        /// <summary>
        /// This method returns the orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return _orderService.GetAllOrders();
        } 
        /// <summary>
        /// This method Places order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            _orderService.PlaceOrder(order);
            return Ok();
        }
    }

}
