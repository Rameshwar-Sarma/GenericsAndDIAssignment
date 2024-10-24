using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int orderId); 
        void PlaceOrder(Order order);
    }


}
