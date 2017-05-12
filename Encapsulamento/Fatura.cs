using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private IList<Pagamento> pagamentos;
        public bool Pago { get; set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            pagamentos.Add(pagamento);

            

            if (ValorTotalDosPagamento() >= this.Valor)
            {
                this.Pago = true;
            }
        }

        private double ValorTotalDosPagamento()
        {
            double total = 0;

            foreach (var pgto in pagamentos)
            {
                total += pgto.Valor;
            }
            return total;
        }
    }
}
