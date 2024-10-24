using ECommerceAPI.Models;
using ECommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        /// <summary>
        /// This method Get Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetAllProducts();
        }  

        /// <summary>
        /// This method add Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.AddProduct(product);
            return Ok();
        }
    }

}
