using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    //basic layout of the compare strategy classes
    public interface ComparePairs
    {
        bool ComparePeople(Person a, Person b);
    }
}
