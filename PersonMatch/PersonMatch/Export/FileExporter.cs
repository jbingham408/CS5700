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
            Console.Write("Writing matches to the output file.\n");
            if(matches.Count == 0)
            {
                writer.Write("No Matches found");
                return;
            }
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
