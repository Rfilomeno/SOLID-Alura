using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioDaResponsabilidadeUnica_Solid
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraDeSalario regra) : base(regra)
        {

        }
    }
}
