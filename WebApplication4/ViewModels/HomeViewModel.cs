using System.Collections.Generic;
using WebApplication4.Data.Models;

namespace WebApplication4.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Car> favCars { get; set; }
	}
}
