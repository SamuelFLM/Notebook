
using C.Models;
using Newtonsoft.Json;
using Nt.Models;

namespace Venda.Models
{
    public class Produto
    {
        public Produto() { }

        [JsonProperty("Cliente")]
        public List<Cliente> Clientes = new List<Cliente>();
        [JsonProperty("Fornecedor")]
        public List<Fornecedor> Fornecedores = new List<Fornecedor>();
        [JsonProperty("Produto")]
        public List<Notebook> Notebooks = new List<Notebook>();
        [JsonProperty("Vendedor")]
        public List<Vendedor> Vendedores = new List<Vendedor>();

        public void FinalizarCompra()
        {

        }
    }
}