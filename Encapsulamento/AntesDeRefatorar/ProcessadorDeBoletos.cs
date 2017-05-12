using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento.AntesDeRefatorar
{
    public class ProcessadorDeBoletos
    {
        public void Processa(List<Boleto> boletos, Fatura fatura)
        {

            double total = 0;

            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.Pagamentos.Add(pagamento);

                total += boleto.Valor;
            }

            if (total >= fatura.Valor)
            {
                fatura.Pago = true;
            }
        }
    }
}
