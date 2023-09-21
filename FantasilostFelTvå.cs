using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3._2_Polymorfism
{
    internal class FantasilostFelTvå : UserError
    {
        internal override string UEMessage()
        {
            return "Fantasilöst fel två!";
        }
    }
}
