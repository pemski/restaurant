using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class SaladBuffet : Product
    {
        protected override decimal ReturnCost()
        {
            return 5m;
        }

        protected override string ReturnName()
        {
            return "Bar sałatkowy";
        }
    }
}
