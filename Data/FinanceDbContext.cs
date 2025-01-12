using Microsoft.EntityFrameworkCore;
using PersonalFinanceTracker.Models;  // Для доступу до класу Expense

namespace PersonalFinanceTracker.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }  // DbSet для класу Expense
    }
}
