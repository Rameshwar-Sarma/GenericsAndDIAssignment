using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id); 
        void AddProduct(Product product);
    }

}
