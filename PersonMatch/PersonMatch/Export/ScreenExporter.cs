using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PersonMatcher
{
    public class ScreenExporter : Exporter
    {
        public List<Person> list { get; set; }
        public override void Write(List<int[]> matches)
        {
            if(matches.Count == 0)
            {
                Console.Write("No Matches Found");
                return;
            }
            foreach (int[] id in matches)
            {
                Console.Write("Match:\n");
                foreach (int i in id)
                {
                    foreach (Person person in list)
                    {
                        if (person.ObjectId == i)
                        {
                            Console.Write("\tId=" + person.ObjectId + ", Name=" + person.FirstName
                                + " " + person.MiddleName + " " + person.LastName
                                + ", Birthday=" + person.BirthMonth + "/" + person.BirthDay + "/" + person.BirthYear + "\n");
                        }
                    }
                }
            }
        }

        public override void Write(List<int[]> matches, string filename)
        {
            throw new NotImplementedException();
        }
    }
}
