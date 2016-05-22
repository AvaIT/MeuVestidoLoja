using MeuVestido.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuVestido.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContex _context()=new EfDbContex();
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
