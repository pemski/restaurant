using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Meal : Product
    {
        protected AdditiveCollection SelectedAdditives;
        protected IEnumerable<Product> PossibeAdditives;


        public Meal()
        {
            SelectedAdditives = new AdditiveHashSet();
        }
    }
}
