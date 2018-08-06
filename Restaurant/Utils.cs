using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public static class Utils
    {
        public static string PrintCost(this decimal cost)
        {
            return cost.ToString("N2", CultureInfo.InvariantCulture);
        }
    }
}
