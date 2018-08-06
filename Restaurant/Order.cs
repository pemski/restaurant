﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {
        private List<Meal> orderedMeals;
        public IEnumerable<Meal> OrderedMeals { get { foreach (var meal in orderedMeals) yield return meal; } }


        public Order()
        {
            orderedMeals = new List<Meal>();
        }


        public void Add(Meal meal, int quantity)
        {
            if (meal == null)
                throw new ArgumentNullException("meal", "Order.Add: added meal cannot be null.");

            if (quantity <= 0)
                return;

            foreach (int q in Enumerable.Range(0, quantity))
                orderedMeals.Add(meal);
        }


        public void Remove(Meal meal, int quantity)
        {
            if (meal == null)
                throw new ArgumentNullException("meal", "Order.Remove: removed meal cannot be null.");

            if (quantity <= 0)
                return;

            foreach (int q in Enumerable.Range(0, quantity))
                orderedMeals.Remove(meal);
        }


        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            foreach (var meal in orderedMeals.Distinct())
            {
                int quantity = OrderedMeals.Where(m => m.Equals(meal)).Count();
                if (quantity > 1)
                    text.AppendFormat("(x{0}) ", quantity);
                text.AppendLine(meal.ToString());
            }
            return text.ToString().Trim();
        }
    }
}
