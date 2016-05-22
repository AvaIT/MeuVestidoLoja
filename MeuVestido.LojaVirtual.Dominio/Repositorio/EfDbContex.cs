using MeuVestido.LojaVirtual.Dominio.Entidades;
using MeuVestido.LojaVirtual.Dominio.Properties;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MeuVestido.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContex : DbContex
    {
        public DbSet<Produto> Produtos { get; set; }

        protected  virtual void OnModelCreating(DbModelBuilder modelBuider)
        {
            modelBuider.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuider.Entity<Produto>().ToTable("Produtos");
        }
      

    }
}
