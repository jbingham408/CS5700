using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public class Match
    {
        private List<int[]> matches { get; set; } 
        private int strategyNum { get; set; }
        private List<Person> list { get; set; }

        public Match(int strategy, List<Person> personSet)
        {
            strategyNum = strategy;
            list = personSet;
            matches = new List<int[]>();
        }

        public void FindMatches()
        {
            ComparePairs compare = GetCompareStrategy();
            bool match = false;

            foreach (Person personA in list)
            {
                foreach(Person personB in list)
                {
                    if (personA.ObjectId < personB.ObjectId)
                        match = compare.ComparePeople(personA, personB);

                    if(match)
                    {
                        int[] newMatches = new int[2];
                        newMatches[0] = personA.ObjectId;
                        newMatches[1] = personB.ObjectId;
                        matches.Add(newMatches);
                        //Console.Write(personA.ObjectId + " " + personB.ObjectId + "\n");
                    }
                }
            }

            //foreach (int[] id in matches)
            //{
            //    foreach (int i in id)
            //        Console.Write(i + " ");
            //    Console.Write("\n");
            //}
        }

        public List<int[]> GetMatchesList()
        {
            return matches;
        }
        private ComparePairs GetCompareStrategy()
        {
            ComparePairs compare = null;
            switch (strategyNum)
            {
                case 1:
                    compare = new CompareNameAndSSN();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }

            return compare;
        }
    }
}
