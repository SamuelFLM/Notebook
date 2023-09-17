
using P.Models;

namespace C.Models
{
    public class Cliente : Pessoa
    {
        public Cliente() { }
        public Cliente(string nome, int idade, int telefone, string rua, int numero, string bairro, decimal saldo, string formaDePagamento) : base(nome, idade, telefone, rua, numero, bairro)
        {
            Saldo = saldo;
            FormaDePagamento = formaDePagamento;
        }
        public decimal Saldo { get; set; }
        public string FormaDePagamento { get; set; }

        public void Pagar()
        {

        }
    }
}