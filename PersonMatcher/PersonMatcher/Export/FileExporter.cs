using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    class FileExporter : Exporter
    {
        public override void Write(List<int[]> matches, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            Console.Write("writing to file");
            foreach (int[] id in matches)
            {
                writer.WriteLine(id[0] + ", " + id[1]);
            }
            writer.Close();
        }

        public override void Write(List<int[]> matches)
        {
            throw new NotImplementedException();
        }
    }
}
