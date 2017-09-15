using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public class CompareSSNSFNAndGender : ComparePairs
    {
        //this strategy compares SSN, SFN, and gender of two people.
        //if the total points from the comparison is equal or greater than 2
        //then there is a chance the the two people are the same person.
        public bool ComparePeople(Person a, Person b)
        {
            int points = 0;

            if (a.StateFileNumber == b.StateFileNumber && (a.StateFileNumber != null && b.StateFileNumber != null))
                points++;
            if (a.SocialSecurityNumber == b.SocialSecurityNumber && (a.SocialSecurityNumber != null && b.SocialSecurityNumber != null))
                points++;
            if (a.Gender == b.Gender && (a.Gender != null && b.Gender != null))
                points++;

            if (points >= 2)
                return true;
            return false;

        }
    }
}
