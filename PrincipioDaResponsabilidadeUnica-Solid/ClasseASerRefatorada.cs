﻿using System;

namespace PrincipioDaResponsabilidadeUnica_Solid
{
    class ClasseASerRefatorada
    {
        public class CalculadoraDeSalario
        {
            public double Calcula(Funcionario funcionario)
            {
                if (funcionario.Cargo is Desenvolvedor)
                {
                    return DezOuVintePorcento(funcionario);
                }

                if (funcionario.Cargo is Dba || funcionario.Cargo is Tester)
                {
                    return QuinzeOuVinteCincoPorcento(funcionario);
                }

                throw new Exception("funcionario invalido");
            }

            private double DezOuVintePorcento(Funcionario funcionario)
            {
                if (funcionario.SalarioBase > 3000.0)
                {
                    return funcionario.SalarioBase * 0.8;
                }
                else
                {
                    return funcionario.SalarioBase * 0.9;
                }
            }

            private double QuinzeOuVinteCincoPorcento(Funcionario funcionario)
            {
                if (funcionario.SalarioBase > 2000.0)
                {
                    return funcionario.SalarioBase * 0.75;
                }
                else
                {
                    return funcionario.SalarioBase * 0.85;
                }
            }
        }

        public abstract class Cargo
        {

        }

        public class Funcionario
        {

            public Cargo Cargo { get; private set; }

            public double SalarioBase { get; private set; }

            public Funcionario(Cargo cargo, double salarioBase)
            {
                this.Cargo = cargo;
                this.SalarioBase = salarioBase;
            }

        }
    }


}
