using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public class PersonSet : List<Person>
    {
        public Importer myImporter { get; set; }
        public Exporter myExporter { get; set; }
        public string myImportFilename { get; set; }
        public string myExportFilename { get; set; }
        public ComparePairs myCompareStrategy { get; set; }
        private Match myMatches { get; set; }

        public void ReadInFile()
        {
            myImporter.Read(this, myImportFilename);
        }

        public void GetMatches()
        {
            myMatches = new Match();
            myMatches.FindMatches(this, myCompareStrategy);
        }

        public void WriteMatches()
        {
            if (myExportFilename == null)
                WriteMatchesToScreen();
            else
                WriteMatchesToFile();
        }

        public void WriteMatchesToFile()
        {
            myExporter.Write(myMatches.GetMatchesList(), myExportFilename);
        }

        public void WriteMatchesToScreen()
        {
            myExporter = new ScreenExporter() { list = this };
            myExporter.Write(myMatches.GetMatchesList());
        }

    }
}
