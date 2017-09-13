using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PersonMatcher
{
    public class XMLExporter : Exporter
    {
        private readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Person>),
                        new[] { typeof(Person) });
        public override void write(List<Person> peopleList, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer.BaseStream, peopleList);
            writer.Close();
        }
    }
}
