using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Data.Models;

namespace WebApplication4.Data
{
    public class DBObjects
    {
        public static void Initial (AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if(!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "https://tesla-cars.by/wp-content/webpc-passthru.php?src=https://tesla-cars.by/wp-content/uploads/2022/02/Tesla-Model-S-2021_2.jpg&nocache=1",
                        price = 45000,
                        isFavourity = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://s.auto.drom.ru/img5/catalog/photos/fullsize/ford/fiesta/ford_fiesta_213925.jpg",
                        price = 11000,
                        isFavourity = false,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://avatars.mds.yandex.net/get-verba/1540742/2a00000178874741ebe297e8ba6c4145a1c7/cattouch",
                        price = 65000,
                        isFavourity = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://motor.ru/thumb/1816x0/filters:quality(75):no_upscale()/imgs/2019/09/30/13/3587275/c9a730a1d8ceaf1881baaaad7ec20f056fd83734.jpeg",
                        price = 40000,
                        isFavourity = false,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://images.prismic.io/carwow/a9b25a99-74ae-4ce8-bf98-d20fd9b2b927_Front+%C2%BE+moving.jpg?fit=crop&q=60&w=1125&cs=tinysrgb&auto=format",
                        price = 14000,
                        isFavourity = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {nameCategory = "Электромобили", desc = "Современный вид транспорта"},
                        new Category {nameCategory = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.nameCategory, el);
                }

                return category;
            }
        }
    }
}
