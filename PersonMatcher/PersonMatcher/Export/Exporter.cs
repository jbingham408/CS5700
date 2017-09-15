using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    //basic format for the exporter classes
    public abstract class Exporter
    {
        public abstract void Write(List<int[]> matches, string filename);
        public abstract void Write(List<int[]> matches);
    }
}
