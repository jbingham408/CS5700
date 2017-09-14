﻿using System;
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
        public string myStrategyNum { get; set; }
        private Match myMatches { get; set; }

        public void ReadInFile()
        {
            string[] temp = myImportFilename.Split('.');

            if (temp.Length == 2)
                if (temp[1] == "xml")
                {
                    myImporter = new XMLImporter();
                    myImporter.Read(this, myImportFilename);
                    Console.Write("XML file\n");
                }
                else if (temp[1] == "json")
                {
                    myImporter = new JSONImporter();
                    myImporter.Read(this, myImportFilename);
                    Console.Write("JSON file\n");
                }
                else
                {
                    Console.Write("Error with file type");
                    return;
                }
        }

        public void GetMatches()
        {
            myMatches = new Match(Convert.ToInt32(myStrategyNum), this);
            myMatches.FindMatches();
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
            myExporter = new FileExporter();
            myExporter.Write(myMatches.GetMatchesList(), myExportFilename);
        }

        public void WriteMatchesToScreen()
        {
            myExporter = new ScreenExporter() { list = this };
            myExporter.Write(myMatches.GetMatchesList());
        }

    }
}
