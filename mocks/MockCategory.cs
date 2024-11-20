using WebsiteKh.interfaces;
using WebsiteKh.Models;

namespace WebsiteKh.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ nameCategory = "Электромобили", desc = "Современный транспорт" },
                    new Category{ nameCategory = "Классический", desc = "Хороший транспорт" }
                };
            }
            set
            {

            }
        }
    }
}
