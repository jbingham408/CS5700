using System;
using RaceDataProcessor;
using RaceMonitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RaceMonitorTesting
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void SubjectSubscribeTest()
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

            Assert.AreEqual("1", testAthlete.myStatus);
            Assert.AreEqual("Jason", testAthlete.firstName);
            Assert.AreEqual(1, testAthlete.subscribers.Count);

            AthleteStatusObserver testObserver2 = new AthleteStatusObserver();
            testObserver.observerName = "Test 2";
            testAthlete.Subscribe(testObserver2);
            testAthlete.Notify();

            Assert.AreEqual(2, testAthlete.subscribers.Count);

            testAthlete.Unsubscribe(testObserver2);
            testAthlete.myStatus = "2";
            testAthlete.Notify();

            Assert.AreEqual(1, testAthlete.subscribers.Count);
            Assert.AreEqual("2", testAthlete.myStatus);
        }
    }
}
