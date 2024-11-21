using WebsiteKh.Models;

namespace WebsiteKh.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car getObjectCar(int carId);

    }
}
