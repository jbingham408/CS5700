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
using System.Net.Mail;
using System.Threading;

// This observer will email every once in while, depends on the user settings, to the given email address
// The email will contain all the athletes and information about them

namespace RaceMonitor
{
    public partial class EmailObserver : AthleteObserver
    {
        public string email { get; set; } = null;
        public int timeInterval { get; set; } = 0;
        private bool keepRunning { get; set; } = true;
        private object myLock = new object();

        public EmailObserver()
        {
            InitializeComponent();
        }

        // This function is what will create the email and send it out
        private void Run()
        {
            MailMessage message = new MailMessage();
            int sleepTime = ((timeInterval * 60) * 1000);
            while (keepRunning)
            {
                Thread.Sleep(sleepTime);
                //Thread.Sleep(15000);

                message.To.Add(email);
                message.Subject = "Race Update";
                message.From = new MailAddress("sirpatches408@gmail.com");
                message.Body = messageBody();
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Port = 25;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Timeout = 10000;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("sirpatches408@gmail.com", "pZ18zl3I");
                smtp.Host = "smtp.gmail.com";
                smtp.Send(message);
            }
        }

        //This creates the body of the email
        private string messageBody()
        {
            string body = "Bib # | First Name | Last Name | Distance | Time<br />";
            foreach (var a in observedAthletes.Values)
            {
                body += a.bibNum + "&emsp;|&emsp;" + a.firstName + " | &emsp;" + a.lastName + " | &emsp;"
                    + a.distance[a.distance.Count - 1] + " | &emsp;" + a.time[a.time.Count - 1] + "<br />";
            }

            return body;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!this.emailTextBox.Text.Equals(""))
            {
                email = this.emailTextBox.Text;
                timeInterval = Convert.ToInt32(this.timeIntervalComboList.SelectedItem);
            }
            this.Visible = false;
            Run();
        }

        //this function will tell all athletes that arent being observe to subscribe to this observer
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
