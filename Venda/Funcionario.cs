
using P.Models;

namespace Venda.Models
{
    public class Funcionario : Pessoa
    {

        public Funcionario() { }
        public Funcionario(string nome, int idade, int telefone, decimal comissao) : base(nome, idade, telefone)
        {
            Comissao = comissao;
        }
        public decimal Comissao { get; set; }

        public void CalcularComissao()
        {

        }
    }
}