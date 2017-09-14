

using System.Collections.Generic;

namespace PersonMatcher
{
    public abstract class Importer
    {
        public abstract void Read(List<Person> list, string filename);
    }
}
