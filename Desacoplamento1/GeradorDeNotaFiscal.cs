using System.Collections.Generic;

namespace Desacoplamento
{
    public class GeradorDeNotaFiscal
    {
        private IAcoesAposGerarNF email;
        private IAcoesAposGerarNF dao;
        public IList<IAcoesAposGerarNF> Acoes = new List<IAcoesAposGerarNF>();

        public GeradorDeNotaFiscal(IList<IAcoesAposGerarNF> acoes)
        {
            this.Acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

            foreach (var acao in Acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }
        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }
}
