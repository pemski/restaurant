using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meal : IEquatable<Meal>, ICloneable
    {
        public string Name { get; }
        public decimal Cost { get; }
        public string Currency { get; }
        public MealType Type { get; }
        public IAdditiveCollection SelectedAdditives { get; }

        private IEnumerable<Additive> availableAdditives { get; }
        public IEnumerable<Additive> AvailableAdditives { get { foreach (var additive in availableAdditives) yield return additive; } }

        private IEnumerable<Additive> availableMandatoryAdditives { get; }
        public IEnumerable<Additive> AvailableMandatoryAdditives { get { foreach (var additive in availableMandatoryAdditives) yield return additive; } }



        /// <summary>
        /// Creates a Meal object. Sets Currency field as default value: "zł".
        /// </summary>
        /// <param name="name">Name of the meal</param>
        /// <param name="cost">Cost of the meal</param>
        /// <param name="type">Type of the meal (pizza, soup, etc.)</param>
        /// <param name="availableAdditivesFactory">Object which creates a collection of available additives for the meal</param>
        /// <param name="availableMandatoryAdditivesFactory">Object which creates a collection of available additives for the meal from which one must be added to the meal (rice, potatoes, etc.)</param>
        /// <param name="additiveCollection">A collection to which selected additives are added</param>
        public Meal(string name, decimal cost, MealType type, IAdditiveFactory availableAdditivesFactory, IAdditiveFactory availableMandatoryAdditivesFactory, IAdditiveCollection additiveCollection)
            : this(name, cost, "zł", type, availableAdditivesFactory, availableMandatoryAdditivesFactory, additiveCollection) { }


        /// <summary>
        /// Creates a Meal object.
        /// </summary>
        /// <param name="name">Name of thr meal</param>
        /// <param name="cost">Cost of thr meal</param>
        /// <param name="currency">Currency of the cost</param>
        /// <param name="type">Type of thr meal (pizza, soup, etc.)</param>
        /// <param name="availableAdditivesFactory">Object which creates a collection of available additives for the meal</param>
        /// <param name="availableMandatoryAdditivesFactory">Object which creates a collection of available additives for the meal from which one must be added to the meal (rice, potatoes, etc.)</param>
        /// <param name="additiveCollection">A collection to which selected additives are added</param>
        public Meal(string name, decimal cost, string currency, MealType type, IAdditiveFactory availableAdditivesFactory, IAdditiveFactory availableMandatoryAdditivesFactory, IAdditiveCollection additiveCollection)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name", "Meal constructor: name cannot be empty or null.");

            if (cost < 0)
                throw new ArgumentOutOfRangeException("cost", "Meal constructor: cost cannot be lesser than 0.");

            if (String.IsNullOrWhiteSpace(currency))
                throw new ArgumentNullException("currency", "Meal constructor: currency cannot be empty or null.");

            if (availableAdditivesFactory == null)
                throw new ArgumentNullException("availableAdditivesFactory", "Meal constructor.");

            if (availableMandatoryAdditivesFactory == null)
                throw new ArgumentNullException("availableMandatoryAdditives", "Meal constructor.");

            this.Type = type ?? throw new ArgumentNullException("type", "Meal constructor: meal type cannot be null.");
            this.SelectedAdditives = additiveCollection ?? throw new ArgumentNullException("additiveCollection", "Meal constructor");
            this.Name = name;
            this.Cost = cost;
            this.Currency = currency;
            this.availableAdditives = availableAdditivesFactory.CreateAdditives();
            this.availableMandatoryAdditives = availableMandatoryAdditivesFactory.CreateAdditives();
        }


        /// <summary>
        /// Private constructor for cloning purpose.
        /// </summary>
        /// <param name="name">Name of the meal</param>
        /// <param name="cost">Cost of the meal</param>
        /// <param name="currency">Currency of the cost</param>
        /// <param name="type">Type of the meal (pizza, soup, etc.)</param>
        /// <param name="availableAdditives">A collection of available additives for the meal</param>
        /// <param name="availableMandatoryAdditives">A collection of available additives for the meal from which one must be added to the meal (rice, potatoes, etc.)</param>
        /// <param name="selectedAdditives">A collection of selected additives</param>
        private Meal(string name, decimal cost, string currency, MealType type, IEnumerable<Additive> availableAdditives,
            IEnumerable<Additive> availableMandatoryAdditives, IAdditiveCollection selectedAdditives)
        {
            this.Name = name;
            this.Cost = cost;
            this.Currency = currency;
            this.Type = type;
            this.availableAdditives = availableAdditives;
            this.availableMandatoryAdditives = availableMandatoryAdditives;
            this.SelectedAdditives = selectedAdditives;
        }


        public bool Equals(Meal other)
        {
            if (other == null)
                throw new ArgumentNullException("other", "Meal.Equals: cannot check equality with null.");

            return
                this.SelectedAdditives.Equals(other.SelectedAdditives) &&
                this.Name.Equals(other.Name) &&
                this.Cost == other.Cost &&
                this.Currency.Equals(other.Currency) &&
                this.Type.Equals(other.Type);
        }


        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + this.Name.GetHashCode();
            hash = hash * 23 + this.Cost.GetHashCode();
            hash = hash * 23 + this.Currency.GetHashCode();
            hash = hash * 23 + this.Type.GetHashCode();
            hash = hash * 23 + this.SelectedAdditives.GetHashCode();
            return hash;
        }


        public object Clone()
        {
            return new Meal(this.Name, this.Cost, this.Currency, (MealType)this.Type.Clone(), CopyAdditiveCollection(this.availableAdditives),
                CopyAdditiveCollection(this.availableMandatoryAdditives), (IAdditiveCollection)this.SelectedAdditives.Clone());
        }


        private IEnumerable<Additive> CopyAdditiveCollection(IEnumerable<Additive> source)
        {
            Additive[] availableAdditivesArray = new Additive[source.Count()];
            source.ToList().CopyTo(availableAdditivesArray);
            return availableAdditivesArray.ToList();
        }


        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(String.Format("{0} - {1} {2}", Name, Cost.PrintCost(), Currency));

            foreach(var additive in SelectedAdditives.Additives)
            text.AppendLine(String.Format("\t+ {0}", additive.ToString()));

            return text.ToString().Trim();
        }
    }
}
