using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3._2_Polymorfism
{
    internal class NumericInputError : UserError
    {
        internal override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
}
