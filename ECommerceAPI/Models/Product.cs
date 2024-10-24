using System.Text.Json.Serialization;

namespace ECommerceAPI.Models
{
    /// <summary>
    /// Product Model
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
