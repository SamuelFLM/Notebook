using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C.Models;
using Nt.Models;

namespace Venda.Models
{
    public class Produto
    {
        public Produto() { }
        public Produto(List<Notebook> produtos, List<Vendedor> vendedores, List<Cliente> clientes, List<Fornecedor> fornecedores)
        {
            Produtos = produtos;
            Vendedores = vendedores;
            Clientes = clientes;
            Fornecedores = fornecedores;
        }
        private List<Notebook> Produtos { get; set; }
        private List<Vendedor> Vendedores { get; set; }
        private List<Cliente> Clientes { get; set; }
        private List<Fornecedor> Fornecedores { get; set; }
        private DateTime DataVenda = DateTime.Now;

        
    }
}