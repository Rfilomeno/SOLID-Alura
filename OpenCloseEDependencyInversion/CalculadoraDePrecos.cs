using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseEDependencyInversion
{
    public class CalculadoraDePrecos
    {
        public IFrete frete;
        public ITableDePreco tabela;

        public CalculadoraDePrecos(ITableDePreco tabela, IFrete frete)
        {
            this.tabela = tabela;
            this.frete = frete;
        }
        public double Calcula(Compra produto)
        {
            double desconto = tabela.DescontoPara(produto.Valor);
            double Custofrete = frete.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + Custofrete;
        }
    }
}
