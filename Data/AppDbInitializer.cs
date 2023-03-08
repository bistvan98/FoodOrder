using FoodOrder.Models;
using static System.Net.WebRequestMethods;

namespace FoodOrder.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Restaurant
                if (!context.Restaurants.Any())
                {
                    context.Restaurants.AddRange(new List<Restaurant>() {
                        new Restaurant()
                        {
                            name = "Miskolci Étterem",
                            town = "Miskolc",
                            address = "3530 Miskolc, Meggyesalja utca 18.",
                            phoneNumber = "06705984521",
                            PathToLogo = "https://img.freepik.com/premium-vector/pizza-logo-design_9845-319.jpg",
                            openTime = 8,
                            closeTime = 19
                        }   
                    });

                    context.SaveChanges();
                }

                // Food
                if (!context.Foods.Any())
                {
                    context.Foods.AddRange(new List<Food>() {
                        new Food()
                        {
                            Name = "Songoku Pizza",
                            Price = 1490,
                            Description = "Paradicsomos alap, sonka, gomba, kukorica, sajt",
                            FoodType = Enums.FoodType.PIZZA,
                            PathToImage = "https://img-9gag-fun.9cache.com/photo/av8N1AW_700bwp.webp",
                            IsVegetarian = false
                        },
                        new Food()
                        {
                            Name = "Húsleves",
                            Price = 990,
                            Description = "Zöldségek, hús, egyéb fűszerek",
                            FoodType = Enums.FoodType.SOUP,
                            PathToImage = "https://www.mindmegette.hu/images/297/O/husleves-cernametelttel.jpg",
                            IsVegetarian = false
                        },
                        new Food()
                        {
                            Name = "Vega Pizza",
                            Price = 1390,
                            Description = "Tejfölös alap, paradicsom, uborka, brokkoli, kukorica, sajt",
                            FoodType = Enums.FoodType.PIZZA,
                            PathToImage = "https://www.fitandfunkyetterem.hu/wp-content/uploads/2019/11/IMG-7028-scaled.jpg",
                            IsVegetarian = true
                        },
                        new Food()
                        {
                            Name = "Coca Cola",
                            Price = 490,
                            Description = "Cukros szénsavas üdítőital",
                            FoodType = Enums.FoodType.DRINK,
                            PathToImage = "https://c-pi.niceshops.com/upload/image/product/large/default/45793_bd4c1314.1024x1024.jpg",
                            IsVegetarian = true
                        },
                        new Food()
                        {
                            Name = "Rántott sajt",
                            Price = 1090,
                            Description = "Rántott sajt hasábburgonyával és tartármártással",
                            FoodType = Enums.FoodType.FRESHLYBAKED,
                            PathToImage = "https://kep.cdn.index.hu/1/0/3701/37017/370174/37017455_2826655_4d653e30d16886cee7aa824563559706_wm.jpg",
                            IsVegetarian = true
                        },
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
