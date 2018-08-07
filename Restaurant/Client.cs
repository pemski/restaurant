using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    /// <summary>
    /// Client only holding Order could be removed and just Order could be used, however it stays
    /// in case any personal data (name, address) appears in the future.
    /// </summary>
    public class Client
    {
        public Order Order { get; }


        public Client()
        {
            Order = new Order();
        }
    }
}
