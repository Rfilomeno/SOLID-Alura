using System;
using System.Collections.Generic;

namespace Desacoplamento
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IAcoesAposGerarNF> Acoes = new List<IAcoesAposGerarNF>()
            {
                 new EnviadorDeEmail(),
                 new NotaFiscalDao(),
                 new EnviadorSMS()
            };
            GeradorDeNotaFiscal Gnf = new GeradorDeNotaFiscal(Acoes);
            Fatura fatura = new Fatura(2000, "Rodrigo");
            Gnf.Gera(fatura);
            Console.ReadKey();
        }
    }
}
