using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Salami : Product
    {
        protected override decimal ReturnCost()
        {
            return 2m;
        }

        protected override string ReturnName()
        {
            return "Salami";
        }
    }
}
