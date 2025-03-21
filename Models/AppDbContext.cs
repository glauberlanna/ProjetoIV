using Microsoft.EntityFrameworkCore;

namespace Projeto_jcm_g3_eixo_4_2025_1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {       
        }

        public DbSet<Cachorro> Cachorros { get; set; }
        public DbSet<Alimentacao> Alimentacoes { get; set; }
    }
}
