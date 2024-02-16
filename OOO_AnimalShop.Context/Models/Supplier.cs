using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOO_AnimalShop.Context.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<ProductTypes> ProductTypes { get; set; }
    }
}
