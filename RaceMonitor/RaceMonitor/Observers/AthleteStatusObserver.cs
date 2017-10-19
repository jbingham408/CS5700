using RaceDataProcessor;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

//This observer monitors the status of every athlete
//It will indicate all who have registered and their current status for the event

namespace RaceMonitor
{
    public partial class AthleteStatusObserver : AthleteObserver
    {
        private readonly object myLock = new object();

        public AthleteStatusObserver()
        {
            InitializeComponent();
        }

        //updates the listview with the new data
        protected override void UpdateAthletes()
        {
            athleteStatusListBox.Items.Clear();
            lock (myLock)
            {
                try
                {
                    
                    athleteStatusListBox.BeginUpdate();
                    foreach (var a in observedAthletes.Values)
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
                catch (InvalidOperationException) { }
                athleteStatusListBox.EndUpdate();
            }
        }

        private void AthleteStatusObserver_Load(object sender, System.EventArgs e)
        {
            StartUpdateTimer();
        }

        //checks if there are athletes that arent being observered
        public void CheckForNewRegisters(object aList)
        {
            int count = 0;

            while (count < 11)
            {
                lock (myLock)
                {
                    try
                    {
                        if ((aList as List<Athlete>).Count > observedAthletes.Count)
                        {
                            foreach (Athlete a in (aList as List<Athlete>))
                            {
                                a.Subscribe(this);
                                a.Notify();
                            }
                            count = 0;
                        }
                        else
                            count++;
                    }
                    catch (InvalidOperationException) { }
                }
                Thread.Sleep(3000);
            }
        }
    }
}
