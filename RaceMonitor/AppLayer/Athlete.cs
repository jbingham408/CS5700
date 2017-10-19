using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class stores all the information about the subject

namespace RaceDataProcessor
{
    public class Athlete : Subject
    {
        public int bibNum { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string myStatus { get; set; }
        public List<double> distance = new List<double>();
        public List<DateTime> time = new List<DateTime>();
    }
}
