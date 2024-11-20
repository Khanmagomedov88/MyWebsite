using WebsiteKh.Models;

namespace WebsiteKh.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car getObjectCar(int carId);

    }
}
