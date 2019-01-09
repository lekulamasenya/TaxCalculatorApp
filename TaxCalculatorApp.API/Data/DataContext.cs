using Microsoft.EntityFrameworkCore;
using TaxCalculatorApp.API.Models;

namespace TaxCalculatorApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

       public DbSet<Value> Values { get; set; }
       public DbSet<TaxCalculation> TaxCalculations { get; set; }
    }
}