using System;
using System.Collections.Generic;
using System.Globalization;
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
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name", "Additive: name cannot be empty or null.");

            if (cost < 0)
                throw new ArgumentOutOfRangeException("cost", "Additive: cost cannot be lesser than 0.");

            if (String.IsNullOrWhiteSpace(currency))
                throw new ArgumentNullException("currency", "Additive: currency cannot be empty or null.");

            Name = name;
            Cost = cost;
            Currency = currency;
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} {2}", Name, Cost.PrintCost(), Currency);
        }
    }
}
