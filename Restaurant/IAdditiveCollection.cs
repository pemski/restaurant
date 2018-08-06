using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IAdditiveCollection : ICloneable, IEquatable<IAdditiveCollection>
    {
        IEnumerable<Additive> Additives { get; }
        IEnumerable<Additive> CreateCollection();
        void Add(Additive additive);
        void Remove(Additive additive);
        int GetLength();
    }
}
