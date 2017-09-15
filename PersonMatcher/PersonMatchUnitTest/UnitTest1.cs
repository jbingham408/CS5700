using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonMatcher;

namespace PersonMatchUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareNameAndBirthdateWithTrueMatchTest()
        {
            bool expectedResult = true;
            bool actualResult;

            Person a = new Person
            {
                FirstName = "Joe",
                MiddleName = "Curtis",
                LastName = "Lightning",
                BirthDay = 0,
                BirthMonth = 12,
                BirthYear = 1988
            };
            Person b = new Person
            {
                FirstName = "Joe",
                MiddleName = "",
                LastName = "Lightning",
                BirthDay = 15,
                BirthMonth = 12,
                BirthYear = 1988
            };

            CompareNameAndBirthdate testCompare = new CompareNameAndBirthdate();
            actualResult = testCompare.ComparePeople(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CompareNameAndBirthdateWithFalseMatchTest()
        {
            bool expectedResult = false;
            bool actualResult;

            Person a = new Person
            {
                FirstName = "Joe",
                MiddleName = "Curtis",
                LastName = "Lightning",
                BirthDay = 0,
                BirthMonth = 12,
                BirthYear = 1988
            };
            Person b = new Person
            {
                FirstName = "Jane",
                MiddleName = "Hurricane",
                LastName = "Lightning",
                BirthDay = 1,
                BirthMonth = 7,
                BirthYear = 1995
            };

            CompareNameAndBirthdate testCompare = new CompareNameAndBirthdate();
            actualResult = testCompare.ComparePeople(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CompareNameAndSSNWithTrueMatchTest()
        {
            bool expectedResult = true;
            bool actualResult;

            Person a = new Person
            {
                FirstName = "Joe",
                MiddleName = "Curtis",
                LastName = "Lightning",
                SocialSecurityNumber = "093489124"
            };
            Person b = new Person
            {
                FirstName = "",
                MiddleName = "",
                LastName = "Lightning",
                SocialSecurityNumber = "093489124"
            };

            CompareNameAndSSN testCompare = new CompareNameAndSSN();
            actualResult = testCompare.ComparePeople(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CompareNameAndSSNWithFalseMatchTest()
        {
            bool expectedResult = false;
            bool actualResult;

            Person a = new Person
            {
                FirstName = "Joe",
                MiddleName = "Curtis",
                LastName = "Lightning",
                SocialSecurityNumber = "12314513"
            };
            Person b = new Person
            {
                FirstName = "Jane",
                MiddleName = "Hurricane",
                LastName = "Lightning",
                SocialSecurityNumber = "090982523"
            };

            CompareNameAndSSN testCompare = new CompareNameAndSSN();
            actualResult = testCompare.ComparePeople(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CompareSSNSFNAndGenderWithTrueMatchTest()
        {
            bool expectedResult = true;
            bool actualResult;

            Person a = new Person
            {
                FirstName = "Joe",
                LastName = "Montana",
                SocialSecurityNumber = "53243623",
                StateFileNumber = "674832",
                Gender = "M"
            };
            Person b = new Person
            {
                FirstName = "Jim",
                LastName = "California",
                SocialSecurityNumber = "3235235",
                StateFileNumber = "674832",
                Gender = "M"
            };

            CompareSSNSFNAndGender testCompare = new CompareSSNSFNAndGender();
            actualResult = testCompare.ComparePeople(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CompareSSNSFNAndGenderWithFalseMatchTest()
        {
            bool expectedResult = false;
            bool actualResult;

            Person a = new Person
            {
                FirstName = "Joe",
                LastName = "Montana",
                SocialSecurityNumber = "324363233",
                StateFileNumber = "32636123",
                Gender = "M"
            };
            Person b = new Person
            {
                FirstName = "Joe",
                LastName = "Montana",
                SocialSecurityNumber = "",
                StateFileNumber = "",
                Gender = "M"
            };

            CompareSSNSFNAndGender testCompare = new CompareSSNSFNAndGender(); ;
            actualResult = testCompare.ComparePeople(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
