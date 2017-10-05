using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceMonitor
{
    public class AthleteObserver : Form
    {
        private readonly Dictionary<Int32, Athlete> observedAthletes = new Dictionary<int, Athlete>();

        protected bool repaintNeeded = false;
        private readonly Timer refresh = new Timer();
        private readonly object myLock = new object();

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

                repaintNeeded = true;
            }
        }
    }
}
