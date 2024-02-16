using OOO_AnimalShop.Context.Models;
using OOO_AnimalShop.Context.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOO_AnimalShop.Context
{
    public class ProductTypes
    {
        [Key]
        public string Articul { get; set; }
        public string Name { get; set; }

        public string Init { get; set; } = "шт.";

        [Required]
        public decimal Price { get; set; } = 0;

        public int MaxDiscount { get; set; }
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; } = null;
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; } = null;

        public CategoryTypes CategoryType { get; set; } = CategoryTypes.Male;
        public int Discount { get; set; }

        [Required]
        public int CountInPack { get; set; } = 30;

        public string Description { get; set; } = "Описание отсутсвует!";

        public string ImagePreview { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
