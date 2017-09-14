using System;
using System.Collections.Generic;
using System.IO;
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
            int numOfArgs = args.Length;
            if (numOfArgs != 2 && numOfArgs != 3)
            {
                Console.Write("Error: Incorrect number of parameters given.\n");
                ParameterError();
                return;
            }
            Importer importer = null;
            Exporter exporter = null;
            string strategyNum = null;
            string importFile = null;
            string exportFile = null;

            strategyNum = args[0];
            importFile = args[1];
            if (numOfArgs == 3)
                exportFile = args[2];

            if (!CheckFileExtension(importFile))
            {
                Console.Write("Error: Incorrect File Extension for the import file.\n");
                ParameterError();
                return;
            }

            if(!CheckFileExists(importFile))
            {
                Console.Write("Error: Import file does not exists.\n");
                ParameterError();
                return;
            }

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
                Console.Write("The import file is empty!");
                Console.Write("Press any key to exit.");
                Console.Read();
                return;
            }

            peopleList.GetMatches();

            peopleList.WriteMatches();
        }

        private static void ParameterError()
        {
            Console.Write("You must enter either 2 or 3 parameters.\n");
            Console.Write("The first parameter needs to be a number that represents the strategy to use.\n");
            Console.Write("Those choices are 1, 2, or 3\n");
            Console.Write("The second parameter you need to put in the name of either a json or xml file to read data from.\n");
            Console.Write("The third parameter is an option.\n");
            Console.Write("If you add this parameter it must be a file where the list of matches will be saved.\n");
            Console.Write("Press any key to exit");
            Console.Read();
        }

        private static bool CheckFileExtension(string filename)
        {
            string[] temp = filename.Split('.');

            if (temp.Length == 2)
                if (temp[1] == "xml" || temp[1] == "json")
                    return true;
            return false;
        }

        private static bool CheckFileExists(string filename)
        {
            if (File.Exists(filename))
                return true;
            return false;
        }
    }
}
