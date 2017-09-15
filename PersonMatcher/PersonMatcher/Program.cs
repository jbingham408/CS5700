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
            //Clears the screen when the program starts
            Console.Clear();
            int numOfArgs = args.Length;
            //checks the number of arguments
            if (numOfArgs != 2 && numOfArgs != 3)
            {
                Console.Write("Error: Incorrect number of parameters given.\n");
                ParameterError();
                return;
            }
            Importer importer = null;
            Exporter exporter = null;
            ComparePairs compareStrategy = null;
            string strategyNum = null;
            string importFile = null;
            string exportFile = null;

            strategyNum = args[0];
            importFile = args[1];
            //if 3 arguments then set the exportFile
            if (numOfArgs == 3)
                exportFile = args[2];

            //checks if the first argument is a number
            if(!CheckArgIsNum(args[0]))
            {
                Console.Write("Error: First Parameter must be a number\n");
                ParameterError();
                return;
            }
            //checks if the importFile is the correct format
            if (!CheckFileExtension(importFile))
            {
                Console.Write("Error: Incorrect File Extension for the import file.\n");
                ParameterError();
                return;
            }
            //checks if the file exists
            if(!CheckFileExists(importFile))
            {
                Console.Write("Error: Import file does not exists.\n");
                ParameterError();
                return;
            }

            importer = GetImportStrategy(importFile);
            exporter = GetExportStrategy(numOfArgs, exportFile);
            compareStrategy = GetStrategy(Convert.ToInt32(args[0]));
            //creates the list that will contain the people
            PersonSet peopleList = new PersonSet()
            {
                myImporter = importer,
                myExporter = exporter,
                myImportFilename = importFile,
                myExportFilename = exportFile,
                myCompareStrategy = compareStrategy
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
        //function that outputs who to make the program run correctly
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
        //function that checks the file extension
        private static bool CheckFileExtension(string filename)
        {
            string[] temp = filename.Split('.');

            if (temp.Length == 2)
                if (temp[1] == "xml" || temp[1] == "json")
                    return true;
            return false;
        }
        //function that checks if the file exists
        private static bool CheckFileExists(string filename)
        {
            if (File.Exists(filename))
                return true;
            return false;
        }
        //checks if the string is a number
        private static bool CheckArgIsNum(string num)
        {
            int actualNum;
            if(int.TryParse(num, out actualNum))
                if (actualNum > 0 && actualNum < 4)
                    return true;

            return false;
        }
        //sets the compare strategy
        private static ComparePairs GetStrategy(int num)
        {
            ComparePairs compare = null;
            switch (num)
            {
                case 1:
                    compare = new CompareNameAndSSN();
                    break;
                case 2:
                    compare = new CompareSSNSFNAndGender();
                    break;
                case 3:
                    compare = new CompareNameAndBirthdate();
                    break;
            }

            return compare;
        }
        //set the import strategy
        private static Importer GetImportStrategy(string filename)
        {
            Importer importer = null;

            string[] temp = filename.Split('.');
            if (temp[1] == "xml")
                importer = new XMLImporter();
            else if (temp[1] == "json")
                importer = new JSONImporter();

            return importer;
        }
        //sets the export strategy
        private static Exporter GetExportStrategy(int num, string filename)
        {
            Exporter exporter = null;

            
            if (num == 3)
                exporter = new FileExporter();
            else
                exporter = new ScreenExporter();

            return exporter;
        }
    }
}
