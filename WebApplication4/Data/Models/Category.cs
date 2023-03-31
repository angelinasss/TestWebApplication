using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Data.Models
{
    public class Category
    {
        public int id { get; set; }

        public string nameCategory { get; set; }

        public string desc { get; set; }

        public List<Car> cars { set; get; }
    }
}
