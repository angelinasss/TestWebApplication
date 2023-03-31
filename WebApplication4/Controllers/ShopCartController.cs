using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication4.Data.interfaces;
using WebApplication4.Data.Models;
using WebApplication4.Data.Repository;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class ShopCartController : Controller
    {

        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

    }
}
