using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
                Console.Write("3 args");
            else if (args.Length == 2)
                Console.Write("2 args");
            else
                Console.Write("Incorrect number of arguments");
        }
    }
}
