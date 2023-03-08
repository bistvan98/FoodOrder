using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The names length must be between 1 and 50!")]
        [Display(Name = "Név")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Város")]
        public string town { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        public string PathToLogo { get; set; }
        [Required]
        [Display(Name = "Nyitás")]
        public int openTime { get; set; }
        [Required]
        [Display(Name = "Zárás")]
        public int closeTime { get; set; }

        //Relationship
        public List<Food> Foods { get; set; }

        public static List<Restaurant> listRestaurants(List<Restaurant> restaurants, string town)
        {
            List<Restaurant> foundRestaurants = new List<Restaurant>();

            for(int i = 0; i < restaurants.Count; i++)
            {
                if (restaurants[i].town == town)
                {
                    foundRestaurants.Add(restaurants[i]);
                }
            }

            return foundRestaurants;
        }
    }
}
