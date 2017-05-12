using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseEDependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(500, "sao paulo");
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(),new FreteNovo());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preco da compra é: " + resultado);
            Console.ReadKey();

        }
    }
}
