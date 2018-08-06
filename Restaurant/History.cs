using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    /// <summary>
    /// Class for XML representation of order history.
    /// </summary>
    public class History
    {
        public List<Order> Orders { get; set; }

        public History()
        {
            Orders = new List<Order>();
        }


        public class Order
        {
            public string Client { get; set; }
            public DateTime Date { get; set; }
            public List<Meal> Meals { get; set; }

            public Order()
            {
                Meals = new List<Meal>();
            }
        }


        public class Meal
        {
            public string Name { get; set; }
            public decimal Cost { get; set; }
            public string Currency { get; set; }
            public int Quantity { get; set; }
            public List<Additive> Additives { get; set; }

            public Meal()
            {
                Additives = new List<Additive>();
            }
        }
    }
}
