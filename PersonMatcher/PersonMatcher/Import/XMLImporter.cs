using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace PersonMatcher
{
    public class XMLImporter : Importer
    {
        //Reads in data from an xml file
        private readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Person>),
                        new[] { typeof(Person)});

        public override void Read(List<Person> list, string filename)
        {
            //stores the data in the list<Person>
            StreamReader reader = new StreamReader(filename);
            List<Person> data = serializer.Deserialize(reader.BaseStream) as List<Person>;
            if (data != null)
            {
                foreach (Person person in data)
                    list.Add(person);
            }
        }
    }
}
