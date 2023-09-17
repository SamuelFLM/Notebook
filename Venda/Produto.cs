
using C.Models;
using Nt.Models;

namespace Venda.Models
{
    public class Produto
    {
        public Produto() { }
       
        public List<Notebook> Notebooks = new List<Notebook>();
        public List<Vendedor> Vendedores = new List<Vendedor>();
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Fornecedor> Fornecedores = new List<Fornecedor>();
        private DateTime DataVenda = DateTime.Now;

        public void FinalizarCompra()
        {

        }
    }
}