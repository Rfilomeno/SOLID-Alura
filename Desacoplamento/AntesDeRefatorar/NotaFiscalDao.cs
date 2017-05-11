using System;

namespace Desacoplamento.AntesDeRefatorar
{
    public class NotaFiscalDao
    {
        public void Persiste(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}
