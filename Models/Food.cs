using FoodOrder.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "The names length must be between 1 and 25!")]
        [Display(Name = "Étel neve")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Ár")]
        public int Price { get; set; }
        [Display(Name = "Leírás")]
        public string Description { get; set; }
        [Required]
        public FoodType FoodType { get; set; }
        [Display(Name = "Kép")]
        public string PathToImage { get; set; }
        [Required]
        public bool IsVegetarian { get; set; }
    }
}
