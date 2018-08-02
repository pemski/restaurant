using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Sauce : Product
    {
        protected override decimal ReturnCost()
        {
            return 6m;
        }

        protected override string ReturnName()
        {
            return "Zestaw sosów";
        }
    }
}
