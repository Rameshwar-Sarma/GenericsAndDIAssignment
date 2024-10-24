namespace ECommerceAPI.Models
{
    /// <summary>
    /// Order Model
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        public List<Product> Products { get; set; }  // Link to Product
        public UserSession UserSession { get; set; }  // Link to UserSession
    }

}
