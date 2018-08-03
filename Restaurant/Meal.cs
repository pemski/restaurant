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
        public IEnumerable<Additive> AvailableAdditives { get; }
        public IEnumerable<Additive> AvailableMandatoryAdditives { get; }
        public IAdditiveCollection SelectedAdditives { get; }


        /// <summary>
        /// Creates a Meal object. Sets Currency field as default value: "zł".
        /// </summary>
        /// <param name="name">Name of a meal</param>
        /// <param name="cost">Cost of a meal</param>
        /// <param name="type">Type of a meal (pizza, soup, etc.)</param>
        /// <param name="availableAdditivesFactory">Object which creates a collection of available additives for the meal</param>
        /// <param name="availableMandatoryAdditivesFactory">Object which creates a collection of available additives for the meal from which one must be added to the meal (rice, potatoes, etc.)</param>
        /// <param name="additiveCollection">A collection to which selected additives are added</param>
        public Meal(string name, decimal cost, MealType type, IAdditiveFactory availableAdditivesFactory, IAdditiveFactory availableMandatoryAdditivesFactory, IAdditiveCollection additiveCollection)
            : this(name, cost, "zł", type, availableAdditivesFactory, availableMandatoryAdditivesFactory, additiveCollection) { }


        /// <summary>
        /// Creates a Meal object.
        /// </summary>
        /// <param name="name">Name of a meal</param>
        /// <param name="cost">Cost of a meal</param>
        /// <param name="type">Type of a meal (pizza, soup, etc.)</param>
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
            this.AvailableAdditives = availableAdditivesFactory.CreateAdditives();
            this.AvailableMandatoryAdditives = availableMandatoryAdditivesFactory.CreateAdditives();
        }
    }
}
