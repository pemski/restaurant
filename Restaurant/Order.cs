using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order : INotifyPropertyChanged
    {
        private List<Meal> orderedMeals;
        public IEnumerable<Meal> OrderedMeals { get { foreach (var meal in orderedMeals) yield return meal; } }


        public Order()
        {
            orderedMeals = new List<Meal>();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOrderChange()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderedMeals"));
        }


        public void Add(Meal meal, int quantity)
        {
            if (meal == null)
                throw new ArgumentNullException("meal", "Order.Add: added meal cannot be null.");

            if (quantity <= 0)
                return;

            foreach (int q in Enumerable.Range(0, quantity))
                orderedMeals.Add(meal);
            NotifyOrderChange();
        }


        public void Remove(Meal meal, int quantity)
        {
            if (meal == null)
                throw new ArgumentNullException("meal", "Order.Remove: removed meal cannot be null.");

            if (quantity <= 0)
                return;

            foreach (int q in Enumerable.Range(0, quantity))
                orderedMeals.Remove(meal);
            NotifyOrderChange();
        }


        public void ResetOrder()
        {
            orderedMeals.Clear();
            NotifyOrderChange();
        }


        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            foreach (var meal in orderedMeals.Distinct())
            {
                int quantity = OrderedMeals.Where(m => m.Equals(meal)).Count();
                text.AppendFormat("(x{0}) ", quantity);
                text.AppendLine(meal.ToString());
            }
            return text.ToString().Trim();
        }
    }
}
