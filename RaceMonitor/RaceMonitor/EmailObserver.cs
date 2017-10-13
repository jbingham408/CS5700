using RaceDataProcessor;
using System;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace RaceMonitor
{
    class EmailObserver : AthleteObserver
    {
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label timeIntervalLabel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox timeIntervalComboList;
        public string email { get; set; } = null;
        public int timeInterval { get; set; } = 0;
        private bool keepRunning { get; set; } = true;

        private void InitializeComponent()
        {
            this.timeIntervalComboList = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.timeIntervalLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeIntervalComboList
            // 
            this.timeIntervalComboList.FormattingEnabled = true;
            this.timeIntervalComboList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "30"});
            this.timeIntervalComboList.Location = new System.Drawing.Point(132, 74);
            this.timeIntervalComboList.Name = "timeIntervalComboList";
            this.timeIntervalComboList.Size = new System.Drawing.Size(49, 21);
            this.timeIntervalComboList.TabIndex = 0;
            this.timeIntervalComboList.Text = "1";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(132, 39);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(286, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(50, 42);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(76, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email Address:";
            // 
            // timeIntervalLabel
            // 
            this.timeIntervalLabel.AutoSize = true;
            this.timeIntervalLabel.Location = new System.Drawing.Point(15, 77);
            this.timeIntervalLabel.Name = "timeIntervalLabel";
            this.timeIntervalLabel.Size = new System.Drawing.Size(111, 13);
            this.timeIntervalLabel.TabIndex = 3;
            this.timeIntervalLabel.Text = "Time Between Emails:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(53, 124);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(329, 124);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EmailObserver
            // 
            this.ClientSize = new System.Drawing.Size(452, 161);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.timeIntervalLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.timeIntervalComboList);
            this.Name = "EmailObserver";
            this.Text = "Email Notification Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, System.EventArgs e)
        {
            if (!this.emailTextBox.Text.Equals(""))
            {
                email = this.emailTextBox.Text;
                timeInterval = Convert.ToInt32(this.timeIntervalComboList.SelectedItem);
            }
            this.Hide();

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
                message.From = new MailAddress("dontreply@myraceevent.com");
                message.Body = messageBody();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Send(message);
            }
        }

        private string messageBody()
        {
            string body = "";

            return body;
        }
    }
}
