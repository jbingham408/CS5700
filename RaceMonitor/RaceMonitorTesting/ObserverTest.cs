using System;
using RaceDataProcessor;
using RaceMonitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RaceMonitorTesting
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void BaseObserverTest()
        {
            Athlete testAthlete = new Athlete()
            {
                bibNum = 8,
                firstName = "Jason",
                lastName = "Bingham",
                age = 28,
                gender = "M",
                myStatus = "1"
            };
            testAthlete.distance.Add(0.0);
            testAthlete.time.Add(new DateTime(2017, 10, 18, 10, 5, 0));

            AthleteObserver testObserver = new AthleteObserver();
            testObserver.observerName = "Test 1";
            testAthlete.Subscribe(testObserver);
            testAthlete.Notify();

            Assert.AreEqual(1, testObserver.observedAthletes.Count);
            Assert.AreEqual("Test 1", testObserver.observerName);
            Assert.IsTrue(testObserver.observedAthletes.ContainsKey(testAthlete.bibNum));

            testAthlete.myStatus = "2";
            testAthlete.Notify();

            Assert.AreEqual("2", testObserver.observedAthletes[testAthlete.bibNum].myStatus);
        }
        [TestMethod]
        public void StatusObserverTest()
        {
            Athlete testAthlete = new Athlete()
            {
                bibNum = 8,
                firstName = "Jason",
                lastName = "Bingham",
                age = 28,
                gender = "M",
                myStatus = "1"
            };
            testAthlete.distance.Add(0.0);
            testAthlete.time.Add(new DateTime(2017, 10, 18, 10, 5, 0));

            AthleteStatusObserver testObserver = new AthleteStatusObserver();
            testObserver.observerName = "Test 1";
            testAthlete.Subscribe(testObserver);
            testAthlete.Notify();

            Assert.AreEqual(1, testObserver.observedAthletes.Count);
            Assert.AreEqual("Test 1", testObserver.observerName);
            Assert.IsTrue(testObserver.observedAthletes.ContainsKey(testAthlete.bibNum));
        }
        [TestMethod]
        public void EmailObserverTest()
        {
            Athlete testAthlete = new Athlete()
            {
                bibNum = 8,
                firstName = "Jason",
                lastName = "Bingham",
                age = 28,
                gender = "M",
                myStatus = "1"
            };
            testAthlete.distance.Add(0.0);
            testAthlete.time.Add(new DateTime(2017, 10, 18, 10, 5, 0));

            EmailObserver testObserver = new EmailObserver();
            testObserver.observerName = "Test 1";
            testObserver.email = "Test@test.com";
            testObserver.timeInterval = 5;
            testAthlete.Subscribe(testObserver);
            testAthlete.Notify();

            Assert.AreEqual(1, testObserver.observedAthletes.Count);
            Assert.AreEqual("Test 1", testObserver.observerName);
            Assert.IsTrue(testObserver.observedAthletes.ContainsKey(testAthlete.bibNum));
            Assert.AreEqual(5, testObserver.timeInterval);
            Assert.AreEqual("Test@test.com", testObserver.email);
        }
        [TestMethod]
        public void CompareObserverTest()
        {
            Athlete testAthlete1 = new Athlete()
            {
                bibNum = 8,
                firstName = "Jason",
                lastName = "Bingham",
                age = 28,
                gender = "M",
                myStatus = "1"
            };
            Athlete testAthlete2 = new Athlete()
            {
                bibNum = 70,
                firstName = "Jim",
                lastName = "Scott",
                age = 23,
                gender = "M",
                myStatus = "1"
            };
            testAthlete1.distance.Add(0.0);
            testAthlete1.time.Add(new DateTime(2017, 10, 18, 10, 5, 0));
            testAthlete2.distance.Add(0.0);
            testAthlete2.time.Add(new DateTime(2017, 10, 18, 10, 5, 0));

            ComparisonObserver testObserver = new ComparisonObserver();
            testObserver.observerName = "Test 1";
            testAthlete1.Subscribe(testObserver);
            testAthlete1.Notify();
            testAthlete2.Subscribe(testObserver);
            testAthlete2.Notify();

            Assert.AreEqual(2, testObserver.observedAthletes.Count);
            Assert.AreEqual("Test 1", testObserver.observerName);
            Assert.IsTrue(testObserver.observedAthletes.ContainsKey(testAthlete1.bibNum));
            Assert.IsTrue(testObserver.observedAthletes.ContainsKey(testAthlete2.bibNum));
        }
        [TestMethod]
        public void SingleAthleteObserverTest()
        {
            Athlete testAthlete = new Athlete()
            {
                bibNum = 8,
                firstName = "Jason",
                lastName = "Bingham",
                age = 28,
                gender = "M",
                myStatus = "1"
            };
            testAthlete.distance.Add(0.0);
            testAthlete.time.Add(new DateTime(2017, 10, 18, 10, 5, 0));

            SingleAthleteObserver testObserver = new SingleAthleteObserver();
            testObserver.observerName = "Test 1";
            testAthlete.Subscribe(testObserver);
            testAthlete.Notify();

            Assert.AreEqual(1, testObserver.observedAthletes.Count);
            Assert.AreEqual("Test 1", testObserver.observerName);
            Assert.IsTrue(testObserver.observedAthletes.ContainsKey(testAthlete.bibNum));
        }
    }
}
