using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseEDependencyInversion
{
    class FreteNovo : IFrete
    {
        public double Para(string cidade)
        {
            return 5;
        }
    }
}
