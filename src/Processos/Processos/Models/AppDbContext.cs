using Microsoft.EntityFrameworkCore;

namespace Processos.Models
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tipo_Processo> Tipo_Processos { get; set; }

        public DbSet<Interessado> Interessado{ get; set; }

        public DbSet<Setor> Setor{ get; set; }

        public DbSet<Movimentacao> Movimentacao{ get; set; }

        public DbSet<Processo> Processo{ get; set; }

        public DbSet<Usuario> Usuario{ get; set; }

        public DbSet<Fluxo> Fluxo { get; set; }

     

    }
}
