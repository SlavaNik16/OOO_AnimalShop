using System.Collections.Generic;

namespace OOO_AnimalShop.Context.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductTypesArticul { get; set; }
        public virtual ProductTypes ProductTypes { get; set; }
        public int Count { get; set; } = 1;

        public ICollection<Order> Orders { get; set; }

        public Product()
        {
            Orders = new HashSet<Order>();
        }
    }
}
