using Microsoft.EntityFrameworkCore;
using WebsiteKh.Data;
using WebsiteKh.Data.Repository;
using WebsiteKh.interfaces;
 

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)  // Задаем базовый путь
    .AddJsonFile("dbSettings.json", optional: false, reloadOnChange: true);  // Загружаем настройки из JSON файла

builder.Services.AddDbContext<AppDBContent>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddTransient<IAllCars, CarRepository>(); // Добавление зависимости
builder.Services.AddTransient<ICarsCategory, CategoryRepository>(); // Добавление зависимости
builder.Services.AddMvc();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope()) // Создаем область для работы с сервисами
{
    var content = scope.ServiceProvider.GetRequiredService<AppDBContent>();

    DBObjects.Initial(content); // Инициализация данных в базе данных
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
