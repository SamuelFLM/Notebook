using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P.Models
{
    public abstract class Endereco
    {
        public Endereco() { }
        public Endereco(string rua, int numero, string bairro)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
        }
        protected string Rua { get; set; }
        protected int Numero { get; set; }
        protected string Bairro { get; set; }

        public void ExibirLogadouro()
        {
            Console.WriteLine("\nLogadouro".ToUpper());
            Console.WriteLine($"\n{Rua} N° {Numero} - Bairro {Bairro}".ToUpper());
        }
    }
}