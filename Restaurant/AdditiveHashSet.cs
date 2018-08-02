using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class AdditiveHashSet : IAdditiveCollection
    {
        public IEnumerable<Additive> Additives { get; }


        public AdditiveHashSet()
        {
            Additives = CreateCollection();
        }


        public IEnumerable<Additive> CreateCollection()
        {
            return new HashSet<Additive>();
        }


        public void Add(Additive additive)
        {
            ((HashSet<Additive>)Additives).Add(additive);
        }


        public void Remove(Additive additive)
        {
            ((HashSet<Additive>)Additives).Remove(additive);
        }


        public int GetLength()
        {
            return Additives.Count();
        }
    }
}
