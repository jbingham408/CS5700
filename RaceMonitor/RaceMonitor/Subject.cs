using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceMonitor
{
    public class Subject
    {
        private readonly object myLock = new object();
        private readonly List<AthleteObserver> subscribers = new List<AthleteObserver>();

        public List<AthleteObserver> Subscribers { get { return subscribers; } }

        public void Subscribe(AthleteObserver observer)
        {
            lock (myLock)
            {
                if (observer != null && !subscribers.Contains(observer))
                    subscribers.Add(observer);
            }
        }

        public void Unsubscribe(AthleteObserver observer)
        {
            lock (myLock)
            {
                if (subscribers.Contains(observer))
                    subscribers.Remove(observer);
            }
        }

        public void Notify()
        {
            lock (myLock)
            {
                foreach (AthleteObserver observer in subscribers)
                    observer.Update(Clone());
            }
        }

        public virtual Subject Clone()
        {
            return MemberwiseClone() as Subject;
        }
    }
}
