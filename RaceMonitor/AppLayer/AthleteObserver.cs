using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is the base observer class
//Contains all the methods and variables used by most or all observers

namespace RaceDataProcessor
{
    public class AthleteObserver : Form
    {
        public Dictionary<Int32, Athlete> observedAthletes = new Dictionary<int, Athlete>();

        protected bool updateNeeded = false;
        protected readonly Timer refresh = new Timer();
        private readonly object myLock = new object();
        public bool keepGoing { get; set; } = false;
        public string observerName { get; set; }

        //updates all the subscribed subjects
        public void Update(Subject s)
        {
            Athlete athlete = s as Athlete;
            if (athlete != null)
            {
                lock (myLock)
                {
                    if (!observedAthletes.ContainsKey(athlete.bibNum))
                        observedAthletes.Add(athlete.bibNum, athlete);
                    else
                        observedAthletes[athlete.bibNum] = athlete;
                }

                updateNeeded = true;
            }
        }

        //starts a timer that will update listviews
        protected void StartUpdateTimer()
        {
            refresh.Interval = 1000;
            refresh.Tick += StartUpdate;
            refresh.Start();
        }

        //updates the listviews
        private void StartUpdate(object sender, EventArgs e)
        {
            if (updateNeeded)
            {
                lock (myLock)
                {
                    UpdateAthletes();
                    updateNeeded = false;
                }
            }
        }

        protected virtual void UpdateAthletes() { }
    }
}
