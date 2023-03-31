using System.Collections;
using System.Collections.Generic;
using WebApplication4.Data.Models;

namespace WebApplication4.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
