using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMatcher
{
    public class CompareNameAndSSN : ComparePairs
    {
        public bool ComparePeople(Person a, Person b)
        {
            int points = 0;

            if (a.FirstName == b.FirstName)
                points++;
            if (a.MiddleName == b.MiddleName)
                points++;
            if (a.LastName == b.LastName)
                points++;
            if (a.SocialSecurityNumber == b.SocialSecurityNumber)
                points++;

            if (points >= 2)
                return true;
            return false;
        }
    }
}
