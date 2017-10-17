using System;
using RaceDataProcessor;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace RaceMonitor
{
    public partial class ObserverCreator : Form
    {
        public bool leaderBoardChecked = false;
        public string observerType { get; set; }
        private object myLock = new object();
        public List<Athlete> aList { get; set; }
        public List<string> athleteBibList = new List<string>();
        private Thread listUpdateThread { get; set; }
        private bool keepGoing { get; set; } = false;

        public ObserverCreator()
        {
            InitializeComponent();
        }       

        private void athleteStatusRB_CheckedChanged(object sender, EventArgs e)
        {
            if (athleteStatusRB.Checked)
                orderStatusCB.Show();
            else
            {
                orderStatusCB.Hide();
                orderStatusCB.Checked = false;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (athleteStatusRB.Checked)
            {
                observerType = "status";
                if (orderStatusCB.Checked)
                    leaderBoardChecked = true;
            }
            else if (emailRB.Checked)
                observerType = "email";
            else if (athleteCompareRB.Checked)
            {
                if (athlete1ComboBox.SelectedIndex > -1 && athlete2ComboBox.SelectedIndex > -1)
                {
                    string[] athlete1 = athlete1ComboBox.Text.Split(' ');
                    string[] athlete2 = athlete2ComboBox.Text.Split(' ');
                    athleteBibList.Add(athlete1[0]);
                    athleteBibList.Add(athlete2[0]);
                    observerType = "compare";
                }

            }
            else if (singleAthleteTrackerRB.Checked) {
                if (athlete1ComboBox.SelectedIndex > -1)
                {
                    string[] athlete = athlete1ComboBox.Text.Split(' ');
                    athleteBibList.Add(athlete[0]);
                    observerType = "compare";
                }
            }
            else
                observerType = null;

            this.DialogResult = DialogResult.OK;
        }

        private void athleteCompareRB_CheckedChanged(object sender, EventArgs e)
        {
            if (athleteCompareRB.Checked)
            {
                athlete1ComboBox.Show();
                athlete2ComboBox.Show();
            }
            else
            {
                athlete1ComboBox.Hide();
                athlete2ComboBox.Hide();
            }
        }

        private void singleAthleteTrackerRB_CheckedChanged(object sender, EventArgs e)
        {
            if (singleAthleteTrackerRB.Checked)
                athlete1ComboBox.Show();
            else
                athlete1ComboBox.Hide();
        }

        private void populateAthleteList()
        {

                athlete1ComboBox.Items.Clear();
                athlete2ComboBox.Items.Clear();
                lock (myLock)
                {
                    try
                    {
                        athlete1ComboBox.BeginUpdate();
                        athlete2ComboBox.BeginUpdate();
                        foreach (Athlete a in aList)
                        {
                            athlete1ComboBox.Items.Add(a.bibNum + " " + a.firstName + " " + a.lastName);
                            athlete2ComboBox.Items.Add(a.bibNum + " " + a.firstName + " " + a.lastName);
                        }
                        athlete1ComboBox.EndUpdate();
                        athlete2ComboBox.EndUpdate();
                    }
                    catch (InvalidOperationException) { }
                }
                            

        }

        private void athlete1ComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            populateAthleteList();
        }
    }
}
