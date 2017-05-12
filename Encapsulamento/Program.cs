using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatura fatura = new Fatura("Rodrigo", 500);
            IList<Boleto> boletos = new List<Boleto>()
            {
                new Boleto(100),
                new Boleto(100),
                new Boleto(100),
                new Boleto(100),
                new Boleto(100)
        };

            ProcessadorDeBoletos processador = new ProcessadorDeBoletos();
            processador.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pago);
           


        }
    }
}
