using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class AdditiveHashSet : AdditiveCollection
    {
        public IEnumerable<Product> Additives { get; set; }


        public AdditiveHashSet()
        {
            Additives = CreateCollection();
        }


        public IEnumerable<Product> CreateCollection()
        {
            return new HashSet<Product>();
        }


        public void Add(Product additive)
        {
            ((HashSet<Product>)Additives).Add(additive);
        }


        public void Remove(Product additive)
        {
            ((HashSet<Product>)Additives).Remove(additive);
        }


        public int GetLength()
        {
            return Additives.Count();
        }
    }
}
