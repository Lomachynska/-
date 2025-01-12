using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PersonalFinanceTracker.Data;
using System.IO;

namespace PersonalFinanceTracker
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FinanceDbContext>
    {
        public FinanceDbContext CreateDbContext(string[] args)
        {
            // Створюємо налаштування для підключення до бази даних
            var optionsBuilder = new DbContextOptionsBuilder<FinanceDbContext>();

            // Потрібно вказати правильний шлях до конфігурації SQLite
            optionsBuilder.UseSqlite("Data Source=personal_finance_tracker.db");

            return new FinanceDbContext(optionsBuilder.Options);
        }
    }
}
