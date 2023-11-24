using Microsoft.EntityFrameworkCore;

namespace WebApiServices.Models
{
    public class CarSalesContext : DbContext
    {
        public CarSalesContext(DbContextOptions<CarSalesContext> options)
        : base(options)
        {
        }

        public DbSet<CarSales> CarSales { get; set; } = null!;
    }
}
