using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOO_AnimalShop.Context.Models
{
    public class PunktVidachi
    {
        public int Id { get; set; }
        [Required]
        public string Index { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Nomer { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
