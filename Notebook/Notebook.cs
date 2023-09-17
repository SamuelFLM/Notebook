using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook
{
    public abstract class Notebook : INotebook
    {
        public Notebook(){}
        public Notebook(string marca){}
        protected string Marca { get; set; }
        protected string Fabricante { get; set; }
        protected string Processador { get; set; }
        protected int Memoria { get; set; }
        protected string PlacaDeVideo { get; set; }
        protected decimal Preco { get; set; }

        public void Desligar()
        {
            Console.WriteLine("Desligando.......");
        }

        public void ExibirConfiguracao()
        {
            Console.WriteLine($"\nMarca: {Marca}".ToUpper());
            Console.WriteLine($"\nFabricante: {Fabricante}".ToUpper());
            Console.WriteLine($"\nProcessador: {Processador}".ToUpper());
            Console.WriteLine($"\nMemoria: {PlacaDeVideo}".ToUpper());
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando.......");
        }
    }
}