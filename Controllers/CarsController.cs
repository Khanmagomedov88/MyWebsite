using Microsoft.AspNetCore.Mvc;
using WebsiteKh.interfaces;
using WebsiteKh.ViewModels;

namespace WebsiteKh.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;  
        private readonly ICarsCategory _allCategories;  

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;

        }

        public ViewResult List()
        {
            CarsListViewModel model = new CarsListViewModel();
            ViewBag.Title = "Список автомобилей";

            var cars = _allCars.Cars.ToList();
            Console.WriteLine($"Количество автомобилей в репозитории: {cars.Count}");

            model.allCars = cars;
            model.currCategory = "Автомобили";

            return View(model);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
