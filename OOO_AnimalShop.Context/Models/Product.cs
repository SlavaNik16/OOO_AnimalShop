using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
