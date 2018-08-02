using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface AdditiveCollection
    {
        IEnumerable<Product> Additives { get; set; }
        IEnumerable<Product> CreateCollection();
        void Add(Product additive);
        void Remove(Product additive);
        int GetLength();
    }
}
