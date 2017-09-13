using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PersonMatcher
{
    public class JSONExporter : Exporter
    {
        private static readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>),
                     new[] { typeof(Person) });
        public override void write(List<Person> peopleList, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            serializer.WriteObject(writer.BaseStream, peopleList);
            writer.Close();
        }
    }
}
