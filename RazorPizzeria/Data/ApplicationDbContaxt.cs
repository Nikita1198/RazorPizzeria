using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public class ApplicationDbContaxt : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContaxt(DbContextOptions<ApplicationDbContaxt> options)
            : base(options)
        {

        }

    }
}
