using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> _orders = new();

        public IEnumerable<Order> GetAllOrders()
        {
            return _orders;
        }

        public Order GetOrderById(int orderId)
        {
            return _orders.FirstOrDefault(o => o.Id == orderId);
        }

        public void PlaceOrder(Order order)
        {
            _orders.Add(order);
        }
    }


}
