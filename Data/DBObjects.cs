using WebsiteKh.Models;

namespace WebsiteKh.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            // Изменение: Переместили всю логику инициализации базы данных внутрь области `using`, чтобы исключить использование "уничтоженного" контекста.
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
                content.SaveChanges(); // Изменение: Добавлен вызов `SaveChanges()` для сохранения категорий.
            }

            if (content.Car.Any())
            {
                content.Car.RemoveRange(content.Car); 
                content.SaveChanges();
            }

            if (!content.Car.Any())
            {
                content.Car.AddRange( // Изменение: исправили вызов на `content.Car.AddRange` вместо `content.AddRange`.
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Быстрый электромобиль",
                        description = "Tesla — это современный электрический автомобиль, который обеспечивает высокую скорость, комфорт и экологичность.",
                        img = "/img/Tesla.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        сategory = Categories["Электромобили"] // Изменение: Исправлено имя категории.
                    },
                    new Car
                    {
                        name = "Mercedes-Benz",
                        shortDesc = "Премиальный автомобиль",
                        description = "Mercedes-Benz — это премиальный автомобиль с высококлассным дизайном и технологиями.",
                        img = "/img/Mercedes-Benz.jpg",
                        price = 270,
                        isFavorite = true,
                        available = true,
                        сategory = Categories["Классический"]
                    },
                    new Car
                    {
                        name = "Mercedes-Benz",
                        shortDesc = "Премиальный автомобиль",
                        description = "Mercedes-Benz — это премиальный автомобиль с высококлассным дизайном и технологиями.",
                        img = "/img/Mercedes-Benz.jpg",
                        price = 270,
                        isFavorite = true,
                        available = true,
                        сategory = Categories["Классический"]
                    },
                    new Car
                    {
                        name = "BMW",
                        shortDesc = "Быстрый автомобиль",
                        description = "BMW — сочетание скорости, мощности и стильного дизайна.",
                        img = "/img/BMW.jpg",
                        price = 25000,
                        isFavorite = true,
                        available = true,
                        сategory = Categories["Классический"]
                    },
                    new Car
                    {
                        name = "Ford",
                        shortDesc = "Семейный автомобиль",
                        description = "Ford — удобный и надежный автомобиль для всей семьи.",
                        img = "/img/Ford.jpg",
                        price = 25000,
                        isFavorite = true,
                        available = true,
                        сategory = Categories["Классический"]
                    }
                );
                content.SaveChanges(); // Изменение: Добавлен вызов `SaveChanges()` для сохранения автомобилей.
                Console.WriteLine("Автомобили добавлены!");
            }
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]{
                        new Category{ nameCategory = "Электромобили", desc = "Современный транспорт" }, // Изменение: Исправлено имя категории.
                        new Category{ nameCategory = "Классический", desc = "Хороший транспорт" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach (var c in list)
                    {
                        category.Add(c.nameCategory, c);
                    }
                }
                return category;
            }
            set { }
        }
    }
}
