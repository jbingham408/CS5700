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
using System.Threading;

// This observer will monitor two athletes and compare their data

namespace RaceMonitor
{
    public partial class ComparisonObserver : AthleteObserver
    {
        private Athlete athlete1 { get; set; }
        private Athlete athlete2 { get; set; }
        private object myLock = new object();
        public ComparisonObserver()
        {
            InitializeComponent();
        }

        //Loads in the basic info for each athlete
        private void ComparisonObserver_Load(object sender, EventArgs e)
        {
            athlete1 = observedAthletes.Values.ElementAt(0);
            athlete2 = observedAthletes.Values.ElementAt(1);
            athlete1BibText.Text = athlete1.bibNum.ToString();
            athlete1FirstNameText.Text = athlete1.firstName;
            athlete1LastNameText.Text = athlete1.lastName;
            athlete2BibText.Text = athlete2.bibNum.ToString();
            athlete2FirstNameText.Text = athlete2.firstName;
            athlete2LastNameText.Text = athlete2.lastName;
            keepGoing = true;
            StartUpdateTimer();
        }

        //updates the listview with all the new data
        protected override void UpdateAthletes()
        {
            string[] row = new string[3];
            athlete1ListBox.Items.Clear();
            athlete1ListBox.BeginUpdate();
            for(int i = 0; i < athlete1.distance.Count; ++i)
            {
                row[0] = athlete1.distance[i].ToString();
                row[1] = athlete1.time[i].TimeOfDay.ToString();
                ListViewItem item = new ListViewItem(row);
                athlete1ListBox.Items.Add(item);
            }
            athlete1ListBox.EndUpdate();

            athlete2ListBox.Items.Clear();
            athlete2ListBox.BeginUpdate();
            for (int i = 0; i < athlete2.distance.Count; ++i)
            {
                row[0] = athlete2.distance[i].ToString();
                row[1] = athlete2.time[i].TimeOfDay.ToString();
                ListViewItem item = new ListViewItem(row);
                athlete2ListBox.Items.Add(item);
            }
            athlete2ListBox.EndUpdate();
        }
    }
}
