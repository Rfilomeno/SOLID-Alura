using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento.AntesDeRefatorar
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        public List<Pagamento> Pagamentos { get; private set; }
        public bool Pago { get; set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }


    }
}
