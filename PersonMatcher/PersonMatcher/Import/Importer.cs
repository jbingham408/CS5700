

using System.Collections.Generic;

namespace PersonMatcher
{
    //Basic format for the importer classes
    public abstract class Importer
    {
        public abstract void Read(List<Person> list, string filename);
    }
}
