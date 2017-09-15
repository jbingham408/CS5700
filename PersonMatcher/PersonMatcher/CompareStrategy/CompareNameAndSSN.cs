using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public class CompareNameAndSSN : ComparePairs
    {
        //this strategy class compares first name, middle name, last name and SSN.
        //if the resulting points are greater than or equal to 3, then the people are a match.
        public bool ComparePeople(Person a, Person b)
        {
            int points = 0;

            if (a.FirstName == b.FirstName && (a.FirstName != null && b.FirstName != null))
                points++;
            if (a.MiddleName == b.MiddleName && (a.MiddleName != null && b.MiddleName != null))
                points++;
            if (a.LastName == b.LastName && (a.LastName != null && b.LastName != null))
                points++;
            if (a.SocialSecurityNumber == b.SocialSecurityNumber && (a.SocialSecurityNumber != null && b.SocialSecurityNumber != null))
                points++;

            if (points >= 3)
                return true;
            return false;
        }
    }
}
