using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public class Match
    {
        //List of the people the match
        private List<int[]> matches { get; set; } 

        //goes through the list of people and finds all possible matches and stores them in the list<int[]>
        public void FindMatches(List<Person> list, ComparePairs compareStrategy)
        {
            matches = new List<int[]>();
            foreach (Person personA in list)
            {
                foreach(Person personB in list)
                {
                    if (personA.ObjectId < personB.ObjectId)
                    {
                        if (compareStrategy.ComparePeople(personA, personB))
                        {
                            int[] newMatches = new int[2];
                            newMatches[0] = personA.ObjectId;
                            newMatches[1] = personB.ObjectId;
                            matches.Add(newMatches);
                            //Console.Write(personA.ObjectId + " " + personB.ObjectId + "\n");
                        }
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

        //returns the list of matches
        public List<int[]> GetMatchesList()
        {
            return matches;
        }
    }
}
