using Microsoft.EntityFrameworkCore;
using pruebaDesarrollador.Entity;

namespace pruebaDesarrollador.Data
{
    public class tazaDBContext : DbContext
    {
        public tazaDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cotizador> Cotizador { get; set; }

    }
}
