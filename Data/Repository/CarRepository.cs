using Microsoft.EntityFrameworkCore;
using WebsiteKh.interfaces;
using WebsiteKh.Models;

namespace WebsiteKh.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.сategory);
        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(car => car.isFavorite).Include(c => c.сategory);

        public Car getObjectCar(int carId)
        {
            return appDBContent.Car.FirstOrDefault(car => car.id == carId);
        }
    }
}
