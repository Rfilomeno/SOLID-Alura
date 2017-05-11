using System;

namespace Desacoplamento
{
    public class NotaFiscalDao : IAcoesAposGerarNF
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}
