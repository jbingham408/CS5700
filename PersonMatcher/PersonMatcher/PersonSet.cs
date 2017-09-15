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

        //reads in the file
        public void ReadInFile()
        {
            myImporter.Read(this, myImportFilename);
        }
        //finds the possible matches
        public void GetMatches()
        {
            myMatches = new Match();
            myMatches.FindMatches(this, myCompareStrategy);
        }
        //writes the matches out
        public void WriteMatches()
        {
            if (myExportFilename == null)
                WriteMatchesToScreen();
            else
                WriteMatchesToFile();
        }
        //if there is an export file then it writes the results to a file
        public void WriteMatchesToFile()
        {
            myExporter.Write(myMatches.GetMatchesList(), myExportFilename);
        }
        //if no export file is given then the results are printed to the screen
        public void WriteMatchesToScreen()
        {
            myExporter = new ScreenExporter() { list = this };
            myExporter.Write(myMatches.GetMatchesList());
        }

    }
}
