using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venda.Models
{
    public class Fornecedor
    {
        public Fornecedor() { }
        public Fornecedor(string empresa, int quantidadeAnoGarantia)
        {
            Empresa = empresa;
            QuantidadeAnoGarantia = quantidadeAnoGarantia;
        }
        public string Empresa { get; set; }
        public int QuantidadeAnoGarantia { get; set; }
    }
}