using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new();

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }


}
