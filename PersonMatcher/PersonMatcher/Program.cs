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
            Console.Clear();
            Importer importer = null;
            Exporter exporter = null;
            int numOfArgs = args.Length;
            string strategyNum = args[0];
            string importFile = args[1];
            string exportFile;
            if (numOfArgs == 3)
                exportFile = args[2];
            else
                exportFile = null;

            PersonSet peopleList = new PersonSet()
            {
                myImporter = importer,
                myExporter = exporter,
                myImportFilename = importFile,
                myExportFilename = exportFile,
                myStrategyNum = strategyNum
            };

            peopleList.ReadInFile();

            if (peopleList.Count == 0)
            {
                Console.Write("The file is empty!");
                return;
            }

            peopleList.GetMatches();

            peopleList.WriteMatches();
        }
    }
}
