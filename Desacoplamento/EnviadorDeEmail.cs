using System;

namespace Desacoplamento
{
    public class EnviadorDeEmail : IAcoesAposGerarNF
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando email");
        }
    }
}
