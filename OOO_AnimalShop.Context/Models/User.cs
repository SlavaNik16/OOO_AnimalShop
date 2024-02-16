using OOO_AnimalShop.Context.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_AnimalShop.Context.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Surname { get; set; } = "Гость";
        [Required]
        public string Name { get; set; }
        public string Patronimyc { get; set; } = null;
        [Required]
        public string Login { get; set; } = "Гость";

        [Required]
        public string Password { get; set; }= "Гость";
        public RoleTypes RoleType { get; set; } = RoleTypes.Guest;
    }
}
