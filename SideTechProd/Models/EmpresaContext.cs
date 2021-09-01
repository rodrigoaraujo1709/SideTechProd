using Microsoft.EntityFrameworkCore;

namespace SideTechProd.Models
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext(DbContextOptions<EmpresaContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }

    }
}

