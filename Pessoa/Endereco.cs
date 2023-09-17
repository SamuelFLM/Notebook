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
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }

        public void ExibirLogadouro()
        {
            Console.WriteLine("\nLogadouro".ToUpper());
            Console.WriteLine($"\n{Rua} N° {Numero} - Bairro {Bairro}".ToUpper());
        }
    }
}