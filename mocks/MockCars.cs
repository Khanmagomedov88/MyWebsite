using WebsiteKh.interfaces;
using WebsiteKh.Models;

namespace WebsiteKh.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>{
                    new Car { name = "Tesla", 
                        shortDesc = "Быстрый электромобиль", 
                        img = "/img/Tesla.jpg", 
                        price = 30000, 
                        isFavorite = true, 
                        available = true, 
                        сategory = _categoryCars.AllCategories.First()},
                    new Car { name = "Mercedes-Benz",
                        shortDesc = "Премиальный автомобиль",
                        img = "/img/Mercedes-Benz.jpg",
                        price = 27000,
                        isFavorite = true,
                        available = true,
                        сategory = _categoryCars.AllCategories.Last()},
                    new Car { name = "BMW",
                        shortDesc = "Быстрый автомобиль",
                        img = "/img/BMW.jpg",
                        price = 25000,
                        isFavorite = true,
                        available = true,
                        сategory = _categoryCars.AllCategories.Last()},
                    new Car { name = "Ford",
                        shortDesc = "Семейный автомобиль",
                        img = "/img/Ford.jpg",
                        price = 25000,
                        isFavorite = true,
                        available = true,
                        сategory = _categoryCars.AllCategories.Last()},
                }; 
            }
            set
            {

            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
