using Microsoft.EntityFrameworkCore;
using webApi.Models;
namespace webApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) // base class constructor
        {}
        public DbSet<City> Cities { get; set; } // data context
    }
}