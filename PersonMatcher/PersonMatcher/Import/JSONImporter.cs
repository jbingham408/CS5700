using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PersonMatcher
{
    public class JSONImporter : Importer
    {
        private static readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>),
                     new[] { typeof(Person)});
        public override void Read(List<Person> list, string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<Person> data = serializer.ReadObject(reader.BaseStream) as List<Person>;
            if (data != null)
            {
                foreach (Person thing in data)
                    list.Add(thing);
            }
        }
    }
}
