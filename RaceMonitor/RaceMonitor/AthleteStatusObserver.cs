using RaceDataProcessor;
using System;
using System.Windows.Forms;

namespace RaceMonitor
{
    public partial class AthleteStatusObserver : AthleteObserverDecorator
    {
        private readonly object myLock = new object();

        public AthleteStatusObserver(AthleteObserver obs) : base(obs)
        {
            Decorate();
        }

        protected override void UpdateAthletes()
        {
            athleteStatusListBox.Items.Clear();
            lock (myLock)
            {
                try
                {
                    AthleteObserver tempObs = new AthleteObserver() { observedAthletes = base.decorateObserver.observedAthletes };
                    athleteStatusListBox.BeginUpdate();
                    foreach (var a in tempObs.observedAthletes.Values)
                    {
                        string[] line = new string[5];
                        line[0] = a.bibNum.ToString();
                        line[1] = a.firstName;
                        line[2] = a.lastName;
                        if (a.myStatus == "1")
                            line[3] = "Registered";
                        else if (a.myStatus == "2")
                            line[3] = "Did Not Start";
                        else if (a.myStatus == "3")
                            line[3] = "Started";
                        else if (a.myStatus == "4")
                            line[3] = "On Course";
                        else if (a.myStatus == "5")
                            line[3] = "Did Not Finish";
                        else if (a.myStatus == "6")
                            line[3] = "Finished";
                        ListViewItem newLine = new ListViewItem(line);
                        athleteStatusListBox.Items.Add(newLine);
                    }
                }
                catch (InvalidOperationException e) { }
                athleteStatusListBox.EndUpdate();
            }
        }

        private void AthleteStatusObserver_Load(object sender, System.EventArgs e)
        {
            StartUpdateTimer();
        }

        protected void StartUpdateTimer()
        {
            refresh.Interval = 1000;
            refresh.Tick += StartUpdate;
            refresh.Start();
        }

        private void StartUpdate(object sender, EventArgs e)
        {
            //if (updateNeeded)
            //{
                lock (myLock)
                {
                    UpdateAthletes();
                    updateNeeded = false;
                }
            //}
        }

        public override void Decorate()
        {
            InitializeComponent();
        }
    }
}
