
using P.Models;

namespace Venda.Models
{
    public class Vendedor : Pessoa
    {

        public Vendedor() { }
        public Vendedor(string nome, int idade, int telefone, decimal comissao) : base(nome, idade, telefone)
        {
            Comissao = comissao;
        }
        public decimal Comissao { get; set; }

        public void CalcularComissao()
        {

        }
    }
}