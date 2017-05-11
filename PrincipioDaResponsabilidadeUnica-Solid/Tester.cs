using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioDaResponsabilidadeUnica_Solid
{
    public class Tester : Cargo
    {
        public Tester(IRegraDeSalario regra) : base(regra)
        {
        }
    }
}
