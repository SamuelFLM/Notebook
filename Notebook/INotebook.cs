using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook
{
    public interface INotebook
    {
        void ExibirConfiguracao();
        void Ligar();
        void Desligar();
        abstract void Manutencao();
    }
}