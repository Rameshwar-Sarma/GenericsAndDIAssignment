using System.Text.Json.Serialization;

namespace ECommerceAPI.Models
{
    /// <summary>
    /// User Session Model
    /// </summary>
    public class UserSession
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime LoginTime { get; set; }
        [JsonIgnore]
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
