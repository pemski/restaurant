using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public struct Additive
    {
        public string Name;
        public decimal Cost;
        public string Currency;


        public Additive(string name, decimal cost) : this(name, cost, "zł") { }


        public Additive(string name, decimal cost, string currency)
        {
            Name = name;
            Cost = cost;
            Currency = currency;
        }
    }
}
