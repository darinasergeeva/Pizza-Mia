using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Pizza_Mia.Models
{
    public class PizzaAppContextFactory : IDesignTimeDbContextFactory<PizzaAppContext>
    {
        public PizzaAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PizzaAppContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bd_dishes;Username=postgres;Password=1111");

            return new PizzaAppContext(optionsBuilder.Options);
        }
    }
}