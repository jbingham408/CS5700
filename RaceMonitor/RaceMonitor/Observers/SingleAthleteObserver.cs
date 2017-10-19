using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaceDataProcessor;

// This Observer will observer just one Athlete
// It will keep track of the athletes distance and time

namespace RaceMonitor
{
    public partial class SingleAthleteObserver : AthleteObserver
    {
        private Athlete athlete { get; set; }
        public SingleAthleteObserver()
        {
            InitializeComponent();
        }

        // Enters the basic info about the athlete into the correct textboxes
        private void SingleAthleteObserver_Load(object sender, EventArgs e)
        {
            athlete = observedAthletes.Values.ElementAt(0);
            athleteBibText.Text = athlete.bibNum.ToString();
            athleteFirstNameText.Text = athlete.firstName;
            athleteLastNameText.Text = athlete.lastName;
            keepGoing = true;
            StartUpdateTimer();
        }

        // Whenever there is an update that needs to be displayed
        protected override void UpdateAthletes()
        {
            string[] row = new string[3];
            athleteTrackingListBox.Items.Clear();
            athleteTrackingListBox.BeginUpdate();
            for (int i = 0; i < athlete.distance.Count; ++i)
            {
                row[0] = athlete.distance[i].ToString();
                row[1] = athlete.time[i].TimeOfDay.ToString();
                ListViewItem item = new ListViewItem(row);
                athleteTrackingListBox.Items.Add(item);
            }
            athleteTrackingListBox.EndUpdate();
        }
    }
}
