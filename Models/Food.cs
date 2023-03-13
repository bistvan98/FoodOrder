using FoodOrder.Data.Base;
using FoodOrder.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FoodOrder.Models
{
    public class Food : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Étel neve")]
        [StringLength(25, ErrorMessage = "The names length must be between 1 and 25!")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ár")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Leírás")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Étel típusa")]
        public FoodType FoodType { get; set; }

        [Required]
        [Display(Name = "Vegetáriánus étel?")]
        public bool IsVegetarian { get; set; }

        [Required]
        [Display(Name = "Kép (URL)")]
        public string PathToImage { get; set; }
    }
}
