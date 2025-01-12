using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTracker.Data;  // Для доступу до FinanceDbContext
using PersonalFinanceTracker.Models;

namespace PersonalFinanceTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування залежностей та підключення до бази даних
            var serviceProvider = new ServiceCollection()
                .AddDbContext<FinanceDbContext>(options =>
                    options.UseSqlite("Data Source=personal_finance_tracker.db"))
                .BuildServiceProvider();

            // Отримуємо інстанс DbContext
            var dbContext = serviceProvider.GetRequiredService<FinanceDbContext>();

            try
            {
                // Ініціалізація бази даних та застосування міграцій
                dbContext.Database.Migrate();
                Console.WriteLine("Database initialized successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during database initialization: {ex.Message}");
            }
        }
    }
}
