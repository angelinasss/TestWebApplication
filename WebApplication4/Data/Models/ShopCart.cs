using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }

        public List<ShopCarItem> listShopItems { get; set; }

        public static ShopCart GetCart (IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart (Car car)
        {
                appDBContent.ShopCarItem.Add(new ShopCarItem { 
                ShopCarId = ShopCartId, 
                car = car, 
                price = car.price
                });

            appDBContent.SaveChanges();
        }

        public List<ShopCarItem> getShopItems()
        {
            return appDBContent.ShopCarItem.Where(c => c.ShopCarId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
