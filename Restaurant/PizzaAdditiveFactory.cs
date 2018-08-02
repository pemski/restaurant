using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class PizzaAdditiveFactory : IAdditiveFactory
    {
        public IEnumerable<Additive> CreateAdditives()
        {
            decimal cost = 2m;

            return new List<Additive>
            {
                new Additive("Podwójny ser", cost),
                new Additive("Salami", cost),
                new Additive("Szynka", cost),
                new Additive("Pieczarki", cost)
            };
        }
    }
}
