using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Data.Models
{
    public class OrderDetails
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int CarID { get; set; }

        public uint price { get; set; }

        public virtual Car car { get; set; }

        public virtual Order order { get; set; }
    }
}
