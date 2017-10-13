using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double distance { get; set; }
        public DateTime time { get; set; }
    }
}
