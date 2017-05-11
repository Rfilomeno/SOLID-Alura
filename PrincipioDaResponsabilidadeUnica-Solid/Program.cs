namespace PrincipioDaResponsabilidadeUnica_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario Funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()),2000);

            
            var resultado = calculadora.Calcula(Funcionario);
            System.Console.WriteLine("O salario de um Desenvolvedor que ganha bruto R$ 2000.00 é R$ " + resultado);
        }
    }
}
