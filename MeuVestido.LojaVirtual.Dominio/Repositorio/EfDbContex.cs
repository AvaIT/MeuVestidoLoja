using MeuVestido.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuVestido.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContex : DbContex
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuider)
        {
            modelBuider.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuider.Entity<Produto>().ToTable("Produtos");        
        }

}
