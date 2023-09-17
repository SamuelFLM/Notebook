using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venda.Models
{
    public class Fornecedor
    {
        public Fornecedor() { }
        public Fornecedor(string empresa, string cnpj)
        {
            Empresa = empresa;
            CNPJ = cnpj;
        }
        public string Empresa { get; set; }
        public string CNPJ { get; set; }
        
    }
}