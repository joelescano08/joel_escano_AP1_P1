using joel_escano_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;



namespace joel_escano_AP1_P1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options ) : base(options)
        {

        }

        public DbSet<Cerveza> ViajesEspaciales { get; set; }
    }
}
