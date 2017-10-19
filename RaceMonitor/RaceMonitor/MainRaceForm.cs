using System.Threading;
using System.Windows.Forms;
using RaceDataProcessor;
using System.Collections.Generic;
using System;

namespace RaceMonitor
{
    public partial class MainRaceForm : Form
    {
        private Controller controller { get; set; }
        private Thread dataThread { get; set; }
        private Thread statusThread { get; set; }
        private Thread emailThread { get; set; }
        private AthleteObserver myObserver { get; set; }
        private List<AthleteObserver> observerList = new List<AthleteObserver>();
        private List<Athlete> myAthleteList { get; set; }
        private string importFileName { get; set; } = null;
        private object myLock = new object();

        public MainRaceForm()
        {
            InitializeComponent();
            controller = new Controller();
            dataThread = new Thread(new ParameterizedThreadStart(controller.Run));
        }

        private void MainRaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataThread.IsAlive)
            {
                dataThread.Abort();
                dataThread.Join();
            }
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void runSimBtn_Click(object sender, System.EventArgs e)
        {
            //dataThread.Start("../../../SimulationData/Century Simulation-01.csv");
            int num;
            if (importFileName == null)
                return;
            controller.courseInfo.Id = Convert.ToInt32(courseIdTextBox.Text);
            controller.courseInfo.Name = raceCourseComboBox.SelectedItem.ToString();
            controller.courseInfo.TotalDistance = Convert.ToInt32(courseDistanceTextBox.Text);
            if(Int32.TryParse(eventIdTextBox.Text, out num))
                controller.eventInfo.Id = num;
            else
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                string message = "Event Id must an a number!";
                string caption = "Error detected in Event Id input";
                MessageBox.Show(message, caption, btn);
                return;
            }
            controller.eventInfo.Title = eventTitleTextBox.Text;
            controller.eventInfo.StartDateTime = Convert.ToDateTime(eventDateTextBox.Text + " " + eventTimeTextBox.Text);
            dataThread.Start(importFileName);
            
        }

        private void raceCourseComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(raceCourseComboBox.SelectedItem as string == "Century Race Course")
            {
                courseIdTextBox.Text = "1";
                courseDistanceTextBox.Text = "160934";
                eventDateTextBox.Text = "8/15/2017";
                eventTimeTextBox.Text = "7:00:00 AM";
                importFileName = "../../../SimulationData/Century Simulation-01.csv";
            }
            else if(raceCourseComboBox.SelectedItem as string == "Short Race Course")
            {
                courseIdTextBox.Text = "2";
                courseDistanceTextBox.Text = "16090";
                eventDateTextBox.Text = "8/15/2017";
                eventTimeTextBox.Text = "7:00:00 AM";
                importFileName = "../../../SimulationData/Short Race Simulation-01.csv";
            }
        }

        private void createObserversBtn_Click(object sender, EventArgs e)
        {
            while (controller.myAthletes == null) { Thread.Sleep(1000); }
            myAthleteList = controller.myAthletes;
            ObserverCreator observerCreator = new ObserverCreator() { aList = myAthleteList };
            if (observerCreator.ShowDialog() == DialogResult.OK)
            {
                myAthleteList = controller.myAthletes;
                if (observerCreator.observerType == "status")
                {
                    myObserver = new AthleteStatusObserver();
                    //if (observerCreator.statusAdditionalInfo.Contains("leader"))
                    //    myObserver = new Decorator.LeaderBoardStatusObserver(myObserver as AthleteStatusObserver);
                    statusThread = new Thread(new ParameterizedThreadStart((myObserver as AthleteStatusObserver).CheckForNewRegisters));
                    statusThread.Start(myAthleteList);
                    myObserver.observerName = "Status " + (observerList.Count + 1);
                    observerList.Add(myObserver);
                    updateObserverList();
                    myObserver.Show();
                }
                else if(observerCreator.observerType == "email")
                {
                    myObserver = new EmailObserver();
                    emailThread = new Thread(new ParameterizedThreadStart((myObserver as EmailObserver).CheckForNewRegisters));
                    emailThread.Start(myAthleteList);
                    myObserver.observerName = "Email " + (observerList.Count + 1);
                    observerList.Add(myObserver);
                    updateObserverList();
                    myObserver.Show();
                }
                else if(observerCreator.observerType == "compare")
                {
                    myObserver = new ComparisonObserver();
                    myObserver.observerName = "Comparison " + (observerList.Count + 1);
                    Athlete temp = myAthleteList.Find(a => a.bibNum == Convert.ToInt32(observerCreator.athleteBibList[0]));
                    temp.Subscribe(myObserver);
                    temp.Notify();
                    temp = myAthleteList.Find(a => a.bibNum == Convert.ToInt32(observerCreator.athleteBibList[1]));
                    temp.Subscribe(myObserver);
                    temp.Notify();
                    observerList.Add(myObserver);
                    updateObserverList();
                    myObserver.Show();
                }
                else if(observerCreator.observerType == "single")
                {
                    myObserver = new SingleAthleteObserver();
                    myObserver.observerName = "Single Athlete " + (observerList.Count + 1);
                    Athlete temp = myAthleteList.Find(a => a.bibNum == Convert.ToInt32(observerCreator.athleteBibList[0]));
                    temp.Subscribe(myObserver);
                    temp.Notify();
                    observerList.Add(myObserver);
                    updateObserverList();
                    myObserver.Show();
                }
            }
        }

        private void updateObserverList()
        {
            observerListBox.Items.Clear();
            observerListBox.BeginUpdate();
            foreach(AthleteObserver obs in observerList)
            {
                observerListBox.Items.Add(obs.observerName);
            }
            observerListBox.EndUpdate();
        }
    }
}
