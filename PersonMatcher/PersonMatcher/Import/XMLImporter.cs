using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace PersonMatcher
{
    public class XMLImporter : Importer
    {
        private readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Person>),
                        new[] { typeof(Person)});

        public override void Read(List<Person> list, string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<Person> data = serializer.Deserialize(reader.BaseStream) as List<Person>;
            if (data != null)
            {
                foreach (Person thing in data)
                    list.Add(thing);
            }
        }
    }
}
