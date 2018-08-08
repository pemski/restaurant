using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Client
    {
        public string Name { get; }
        public Order Order { get; }


        public Client(string name)
        {
            this.Name = name;
            Order = new Order();
        }
    }
}
