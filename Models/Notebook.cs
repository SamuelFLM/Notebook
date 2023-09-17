using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Models
{
    public abstract class Notebook : INotebook
    {
        protected string Marca { get; set; }
        protected string Fabricante { get; set; }
        protected string Processador { get; set; }
        protected int Memoria { get; set; }
        protected string PlacaDeVideo { get; set; }
        protected string SistemaOperacional { get; set; }
        protected int AnosGarantia { get; set; }

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void ExibirConfiguracao()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }

        public abstract void Manutencao();
        public abstract string Instalar();
    }
}