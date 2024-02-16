using OOO_AnimalShop.Context.Models.Enums;
using System.ComponentModel.DataAnnotations;

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
