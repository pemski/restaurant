using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Restaurant
{
    public class HistoryXML : IHistoryManagement
    {
        public string FilePath { get; }


        public HistoryXML(string filePath)
        {
            if (String.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException("filePath", "HistoryXML: path cannot be null or empty.");

            if (!Path.GetExtension(filePath).Equals(".xml", StringComparison.InvariantCultureIgnoreCase))
                throw new ArgumentException("HistoryXML: must provide XML file path.", "filePath");

            FilePath = filePath;
        }


        public string Load()
        {
            throw new NotImplementedException();
        }


        public void Save(HistoryData data, Order order)
        {
            History.Order histOrder = CreateOrderElement(data, order);

            if (!File.Exists(FilePath))
            {
                History history = new History();
                history.Orders.Add(histOrder);

                Serialize(history);
            }
            else
            {
                History history = Deserialize();
                history.Orders.Add(histOrder);
                Serialize(history);
            }
        }


        private static History.Order CreateOrderElement(HistoryData data, Order order)
        {
            var histOrder = new History.Order();
            histOrder.Client = data.Client;
            histOrder.Date = data.Date;
            foreach (var meal in order.OrderedMeals.Distinct())
            {
                var histMeal = new History.Meal();
                histMeal.Name = meal.Name;
                histMeal.Cost = meal.Cost;
                histMeal.Currency = meal.Currency;
                histMeal.Quantity = order.OrderedMeals.Count(m => m.Equals(meal));
                foreach (var add in meal.SelectedAdditives.Additives)
                    histMeal.Additives.Add(add);
                histOrder.Meals.Add(histMeal);
            }

            return histOrder;
        }


        private void Serialize(History history)
        {
            using (var stream = new FileStream(FilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(History));
                serializer.Serialize(stream, history);
            }
        }


        private History Deserialize()
        {
            using (var stream = new FileStream(FilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(History));
                return (History)serializer.Deserialize(stream);
            }
        }
    }
}
