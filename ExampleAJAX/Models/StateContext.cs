using System.Data.Entity;

namespace ExampleAJAX.Models
{
    public class StateContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
