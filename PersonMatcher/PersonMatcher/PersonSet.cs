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
        public string myStrategyNum { get; set; }
        
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

        public void writeMatches()
        {
            if(myExportFilename == null)
                writeMatchesToScreen();
            else
            {
                //writePairsToScreen();
                writeMatchesToFile();
            }
        }
        public void writeMatchesToFile()
        {
            string filetype = String.Empty;
            string[] temp = filetype.Split('.');

            if(temp.Length == 2)
            {
                if (temp[1] == "xml")
                {
                    myExporter = new XMLExporter();
                    Console.Write("Output to xml file\n");
                }
                else if (temp[1] == "json")
                {
                    myExporter = new JSONExporter();
                    Console.Write("Output to json file\n");
                }
                else
                    return;
            }
        }

        public void writePairsToScreen()
        {

        }

        public void writeMatchesToScreen()
        {
            foreach (Person person in this)
                Console.WriteLine(person.ObjectId + ": " + person.FirstName);
        }

    }
}
