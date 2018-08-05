using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Client
    {
        public Menu Menu { get; }
        public Order Order { get; }


        public Client()
        {
            Menu = new Menu();
            Order = new Order();
        }
    }
}
