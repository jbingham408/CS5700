using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public class CompareNameAndBirthdate : ComparePairs
    {
        //This strategy class compares first, middle, last name, birth day, birth month, and birth year.
        //If the result is greater than or equal to 4, then the two people are possible matches.
        public bool ComparePeople(Person a, Person b)
        {
            int points = 0;

            if (a.FirstName == b.FirstName && (a.FirstName != null && b.FirstName != null))
                points++;
            if (a.MiddleName == b.MiddleName && (a.MiddleName != null && b.MiddleName != null))
                points++;
            if (a.LastName == b.LastName && (a.LastName != null && b.LastName != null))
                points++;
            if (a.BirthDay == b.BirthDay && (a.BirthDay > 0 && b.BirthDay > 0))
                points++;
            if (a.BirthMonth == b.BirthMonth && (a.BirthMonth > 0 && b.BirthMonth > 0))
                points++;
            if (a.BirthYear == b.BirthYear && (a.BirthMonth > 0 && b.BirthMonth > 0))
                points++;

            if (points >= 4)
                return true;
            return false;
        }
    }
}
