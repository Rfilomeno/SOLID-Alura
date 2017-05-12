﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento.AntesDeRefatorar
{
    public class Boleto
    {
        public double Valor { get; private set; }

        public Boleto(double valor)
        {
            this.Valor = valor;
        }
    }
}
