using System.Collections.Generic;
using WebApplication4.Data.interfaces;
using WebApplication4.Data.Models;

namespace WebApplication4.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category {nameCategory = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {nameCategory = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };

            }
        }
    }
}
