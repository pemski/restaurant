using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meal
    {
        public string Name { get; }
        public decimal Cost { get; }
        public string Currency { get; }
        public MealType Type { get; }
        public IEnumerable<Additive> PossibeAdditives { get; }
        public IAdditiveCollection SelectedAdditives { get; }


        public Meal(string name, decimal cost, MealType type, IAdditiveFactory possibleAdditivesFactory, IAdditiveCollection additiveCollection)
            : this(name, cost, "zł", type, possibleAdditivesFactory, additiveCollection) { }


        public Meal(string name, decimal cost, string currency, MealType type, IAdditiveFactory possibleAdditivesFactory, IAdditiveCollection additiveCollection)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name", "Meal constructor: name cannot be empty or null.");

            if (cost < 0)
                throw new ArgumentOutOfRangeException("cost", "Meal constructor: cost cannot be lesser than 0.");

            if (String.IsNullOrWhiteSpace(currency))
                throw new ArgumentNullException("currency", "Meal constructor: currency cannot be empty or null.");

            if (possibleAdditivesFactory == null)
                throw new ArgumentNullException("possibleAdditivesFactory", "Meal constructor.");

            this.Type = type ?? throw new ArgumentNullException("type", "Meal constructor: meal type cannot be null.");
            this.SelectedAdditives = additiveCollection ?? throw new ArgumentNullException("additiveCollection", "Meal constructor");
            this.Name = name;
            this.Cost = cost;
            this.Currency = currency;
            this.PossibeAdditives = possibleAdditivesFactory.CreateAdditives();
        }
    }
}
