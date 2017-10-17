namespace RaceMonitor
{
    partial class EmailObserver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label timeIntervalLabel;
        private System.Windows.Forms.ComboBox timeIntervalComboList;

        private void InitializeComponent()
        {
            this.timeIntervalComboList = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.timeIntervalLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
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
            this.timeIntervalComboList.Location = new System.Drawing.Point(167, 74);
            this.timeIntervalComboList.Name = "timeIntervalComboList";
            this.timeIntervalComboList.Size = new System.Drawing.Size(49, 24);
            this.timeIntervalComboList.TabIndex = 0;
            this.timeIntervalComboList.Text = "1";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(167, 39);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(286, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(59, 42);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(102, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email Address:";
            // 
            // timeIntervalLabel
            // 
            this.timeIntervalLabel.AutoSize = true;
            this.timeIntervalLabel.Location = new System.Drawing.Point(15, 77);
            this.timeIntervalLabel.Name = "timeIntervalLabel";
            this.timeIntervalLabel.Size = new System.Drawing.Size(146, 17);
            this.timeIntervalLabel.TabIndex = 3;
            this.timeIntervalLabel.Text = "Time Between Emails:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(167, 126);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Submit";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // EmailObserver
            // 
            this.ClientSize = new System.Drawing.Size(520, 161);
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

        #endregion

        private System.Windows.Forms.Button createBtn;
    }
}