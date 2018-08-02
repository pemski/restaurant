using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class NullAdditiveFactory : IAdditiveFactory
    {
        public IEnumerable<Additive> CreateAdditives()
        {
            return new List<Additive>();
        }
    }
}
