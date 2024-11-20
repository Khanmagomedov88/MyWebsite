using WebsiteKh.Models;

namespace WebsiteKh.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
