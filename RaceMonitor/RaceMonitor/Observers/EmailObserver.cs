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

namespace RaceMonitor
{
    public partial class EmailObserver : AthleteObserver
    {
        public string email { get; set; } = null;
        public int timeInterval { get; set; } = 0;
        private bool keepRunning { get; set; } = true;
        public EmailObserver()
        {
            InitializeComponent();
        }


        private void Run()
        {
            MailMessage message = new MailMessage();
            int sleepTime = ((timeInterval * 60) * 1000);
            while (keepRunning)
            {
                Thread.Sleep(sleepTime);
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

        private string messageBody()
        {
            string body = "";

            return body;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!this.emailTextBox.Text.Equals(""))
            {
                email = this.emailTextBox.Text;
                timeInterval = Convert.ToInt32(this.timeIntervalComboList.SelectedItem);
            }
            Run();
        }
    }
}
