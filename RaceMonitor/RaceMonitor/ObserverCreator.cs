using System;
using RaceDataProcessor;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

//A window to indicate which observer to create

namespace RaceMonitor
{
    public partial class ObserverCreator : Form
    {
        public string observerType { get; set; }
        private object myLock = new object();
        public List<Athlete> aList { get; set; }
        public List<string> athleteBibList = new List<string>();
        public List<string> statusAdditionalInfo = new List<string>();


        public ObserverCreator()
        {
            InitializeComponent();
        }       

        //checks if the status observer is selected
        private void athleteStatusRB_CheckedChanged(object sender, EventArgs e)
        {
            if (athleteStatusRB.Checked)
                statusGroupBox.Show();
            else
            {
                statusGroupBox.Hide();
                ageCB.Checked = false;
            }
        }

        //Indicates which observer needs to be created
        private void createBtn_Click(object sender, EventArgs e)
        {
            if (athleteStatusRB.Checked)
            {
                observerType = "status";
                //if (ageCB.Checked)
                //    statusAdditionalInfo.Add("age");
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
                    observerType = "single";
                }
            }
            else
                observerType = null;

            this.DialogResult = DialogResult.OK;
        }

        //checks if the comparison observer is selected
        private void athleteCompareRB_CheckedChanged(object sender, EventArgs e)
        {
            if (athleteCompareRB.Checked)
            {
                athleteGroupBox.Show();
                athlete1ComboBox.Show();
                athlete1Label.Show();
                athlete2ComboBox.Show();
                athlete2Label.Show();
            }
            else
            {
                athlete1ComboBox.Hide();
                athlete1Label.Hide();
                athlete2ComboBox.Hide();
                athlete2Label.Hide();
                athleteGroupBox.Hide();
            }
        }

        //checks if the single athlete observer is selected
        private void singleAthleteTrackerRB_CheckedChanged(object sender, EventArgs e)
        {
            if (singleAthleteTrackerRB.Checked)
            {
                athleteGroupBox.Show();
                athlete1ComboBox.Show();
                athlete1Label.Show();
            }
            else
            {
                athlete1ComboBox.Hide();
                athlete1Label.Hide();
                athleteGroupBox.Hide();
            }
        }

        //inserts all the athletes into the two drop down lists of selectable athletes
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
