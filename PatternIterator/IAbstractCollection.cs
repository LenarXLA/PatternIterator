using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
