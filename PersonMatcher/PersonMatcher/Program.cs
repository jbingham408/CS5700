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
                Console.Write("3 args\n");
            else if (args.Length == 2)
                Console.Write("2 args\n");
            else
                Console.Write("Incorrect number of arguments\n");

            XMLImporter xmlImporter = new XMLImporter();
            JSONImporter jsonImporter = new JSONImporter();
            List<Person> xmlpeopleList = new List<Person>();
            List<Person> jsonpeopleList = new List<Person>();

            xmlImporter.Read(xmlpeopleList, "XML_PersonTestSet_1.xml");
            jsonImporter.Read(jsonpeopleList, "JSON_PersonTestSet_4.json");
            Console.Write(jsonpeopleList[0].FirstName + "\n");
            Console.Write(jsonpeopleList[5].LastName + "\n");
            Console.Write(jsonpeopleList[jsonpeopleList.Count - 1].LastName + "\n");
        }
    }
}
