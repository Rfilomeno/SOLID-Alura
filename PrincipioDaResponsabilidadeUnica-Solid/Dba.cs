using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioDaResponsabilidadeUnica_Solid
{
    public class Dba : Cargo
    {
        public Dba(IRegraDeSalario regra) : base(regra)
        {

        }
    }
}
