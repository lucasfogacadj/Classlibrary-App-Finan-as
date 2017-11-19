using Microsoft.EntityFrameworkCore;
using finlab.Dominio;

namespace finlab.Repositorio
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) :base(options)
        {
        }
        public DbSet<Despesas> Gasto {get; set;}

        public  DbSet<City> Cities{get; set;}

         public DbSet<Members> Members { get; set; }
        
    }
}