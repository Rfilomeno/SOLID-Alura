using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseEDependencyInversion.AntesDeRefatorar
{
    public class Compra
    {
        public double Valor { get; set; }
        public string Cidade { get; set; }

        public Compra(double valor, string cidade)
        {
            this.Valor = valor;
            this.Cidade = cidade;
        }
    }
}
