using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MeatAdditiveFactory : IAdditiveFactory
    {
        public IEnumerable<Additive> CreateAdditives()
        {
            decimal cost = 0m;

            return new List<Additive>
            {
                new Additive("Frytki", cost),
                new Additive("Ryż", cost),
                new Additive("Ziemniaki", cost)
            };
        }
    }
}
