using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public decimal Cost { get; protected set; }
        public string Currency { get; protected set; }


        public Product()
        {
            Name = ReturnName();
            Cost = ReturnCost();
            Currency = ReturnCurrency();
        }


        protected abstract string ReturnName();
        protected abstract decimal ReturnCost();
        protected virtual string ReturnCurrency()
        {
            return "zł";
        }
    }
}
