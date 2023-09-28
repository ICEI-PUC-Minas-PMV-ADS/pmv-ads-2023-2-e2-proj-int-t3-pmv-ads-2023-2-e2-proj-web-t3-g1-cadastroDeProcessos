using Microsoft.EntityFrameworkCore;

namespace Processos.Models
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tipo_Processo> Tipo_Processos { get; set; }    


    }
}
