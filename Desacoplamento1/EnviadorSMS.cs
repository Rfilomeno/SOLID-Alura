using System;

namespace Desacoplamento
{
    class EnviadorSMS : IAcoesAposGerarNF
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando SMS");
        }
    }
    
}
