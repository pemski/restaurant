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


        public object Clone()
        {
            IAdditiveCollection clone = new AdditiveHashSet();
            foreach (var additive in this.Additives)
                clone.Add(additive);
            return clone;
        }


        public bool Equals(IAdditiveCollection other)
        {
            if (this.GetLength() != other.GetLength())
                return false;

            foreach(var add in this.Additives)
            {
                if (!other.Additives.Contains(add))
                    return false;
            }
            return true;
        }


        public override int GetHashCode()
        {
            int hash = 17;
            foreach (var add in Additives)
                hash = hash * 23 + add.GetHashCode();
            return hash;
        }
    }
}
