using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_AnimalShop.Context.Models
{
    public class Order
    {
        [Key]
        public int Nomer { get; set; }
        public DateTimeOffset DateOrder { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset DateSupplier { get; set; } = DateTimeOffset.UtcNow;
        [Required]
        public int PunktVidachiId { get; set; }
        public virtual PunktVidachi PunktVidachi { get; set; }

        public string FIOClient { get; set; } = string.Empty;

        public int Code { get; set; }
        [Required]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public ICollection<Product> Products { get; set; }

        public Order()
        {
            Products = new HashSet<Product>();
        }
    }
}
