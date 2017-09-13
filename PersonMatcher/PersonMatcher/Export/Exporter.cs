using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public abstract class Exporter
    {
        public abstract void write(List<Person> list, string filename);
    }
}
