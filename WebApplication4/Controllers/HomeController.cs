﻿using WebApplication4.Data.interfaces;
using WebApplication4.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
	public class HomeController : Controller
	{
		private IAllCars _carRep;

		public HomeController(IAllCars carRep)
		{
			_carRep = carRep;
		}

		public ViewResult Index()
		{
			var homeCars = new HomeViewModel
			{
				favCars = _carRep.getFavCars
			};
			return View(homeCars);
		}
	}
}
