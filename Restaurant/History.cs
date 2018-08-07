using System;
using System.Collections.Generic;
using System.Globalization;
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

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            foreach (var order in Orders)
            {
                text.AppendLine(order.ToString());
                text.AppendLine();
            }
            return text.ToString().Trim();
        }


        public class Order
        {
            public string Client { get; set; }
            public DateTime Date { get; set; }
            public List<Meal> Meals { get; set; }
            public string Comment { get; set; }

            public Order()
            {
                Meals = new List<Meal>();
            }

            public override string ToString()
            {
                StringBuilder text = new StringBuilder();
                text.AppendLine(String.Format("Client: {0}.", Client));
                text.AppendLine(String.Format("Date: {0}.", Date));
                foreach (var meal in Meals)
                {
                    text.AppendLine(String.Format("\t(x{3}) {0} - {1} {2}", meal.Name, meal.Cost.PrintCost(), meal.Currency, meal.Quantity));
                    foreach (var add in meal.Additives)
                        text.AppendLine(String.Format("\t\t+ {0} - {1} {2}", add.Name, add.Cost.PrintCost(), add.Currency));
                }
                if (!String.IsNullOrWhiteSpace(Comment))
                    text.Append(String.Format("Comment: {0}", Comment));
                return text.ToString().Trim();
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
