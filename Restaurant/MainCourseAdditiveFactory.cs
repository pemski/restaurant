using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MainCourseAdditiveFactory : IAdditiveFactory
    {
        public IEnumerable<Additive> CreateAdditives()
        {
            return new List<Additive>
            {
                new Additive("Bar sałatkowy", 5),
                new Additive("Zestaw sosów", 6)
            };
        }
    }
}
