using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOO_AnimalShop.Context.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
