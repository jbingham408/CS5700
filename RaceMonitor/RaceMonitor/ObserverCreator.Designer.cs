namespace RaceMonitor
{
    partial class ObserverCreator
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
        private void InitializeComponent()
        {
            this.athleteStatusRB = new System.Windows.Forms.RadioButton();
            this.athleteCompareRB = new System.Windows.Forms.RadioButton();
            this.singleAthleteTrackerRB = new System.Windows.Forms.RadioButton();
            this.emailRB = new System.Windows.Forms.RadioButton();
            this.createBtn = new System.Windows.Forms.Button();
            this.orderStatusCB = new System.Windows.Forms.CheckBox();
            this.observersGroup = new System.Windows.Forms.GroupBox();
            this.athlete1ComboBox = new System.Windows.Forms.ComboBox();
            this.athlete2ComboBox = new System.Windows.Forms.ComboBox();
            this.athlete1Label = new System.Windows.Forms.Label();
            this.athlete2Label = new System.Windows.Forms.Label();
            this.observersGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // athleteStatusRB
            // 
            this.athleteStatusRB.AutoSize = true;
            this.athleteStatusRB.Location = new System.Drawing.Point(6, 19);
            this.athleteStatusRB.Name = "athleteStatusRB";
            this.athleteStatusRB.Size = new System.Drawing.Size(128, 17);
            this.athleteStatusRB.TabIndex = 0;
            this.athleteStatusRB.TabStop = true;
            this.athleteStatusRB.Text = "Athlete Status Creator";
            this.athleteStatusRB.UseVisualStyleBackColor = true;
            this.athleteStatusRB.CheckedChanged += new System.EventHandler(this.athleteStatusRB_CheckedChanged);
            // 
            // athleteCompareRB
            // 
            this.athleteCompareRB.AutoSize = true;
            this.athleteCompareRB.Location = new System.Drawing.Point(6, 42);
            this.athleteCompareRB.Name = "athleteCompareRB";
            this.athleteCompareRB.Size = new System.Drawing.Size(162, 17);
            this.athleteCompareRB.TabIndex = 1;
            this.athleteCompareRB.TabStop = true;
            this.athleteCompareRB.Text = "Athlete Comparison Observer";
            this.athleteCompareRB.UseVisualStyleBackColor = true;
            this.athleteCompareRB.CheckedChanged += new System.EventHandler(this.athleteCompareRB_CheckedChanged);
            // 
            // singleAthleteTrackerRB
            // 
            this.singleAthleteTrackerRB.AutoSize = true;
            this.singleAthleteTrackerRB.Location = new System.Drawing.Point(6, 65);
            this.singleAthleteTrackerRB.Name = "singleAthleteTrackerRB";
            this.singleAthleteTrackerRB.Size = new System.Drawing.Size(136, 17);
            this.singleAthleteTrackerRB.TabIndex = 2;
            this.singleAthleteTrackerRB.TabStop = true;
            this.singleAthleteTrackerRB.Text = "Single Athlete Observer";
            this.singleAthleteTrackerRB.UseVisualStyleBackColor = true;
            this.singleAthleteTrackerRB.CheckedChanged += new System.EventHandler(this.singleAthleteTrackerRB_CheckedChanged);
            // 
            // emailRB
            // 
            this.emailRB.AutoSize = true;
            this.emailRB.Location = new System.Drawing.Point(6, 88);
            this.emailRB.Name = "emailRB";
            this.emailRB.Size = new System.Drawing.Size(96, 17);
            this.emailRB.TabIndex = 3;
            this.emailRB.TabStop = true;
            this.emailRB.Text = "Email Observer";
            this.emailRB.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 134);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // orderStatusCB
            // 
            this.orderStatusCB.AutoSize = true;
            this.orderStatusCB.Location = new System.Drawing.Point(221, 31);
            this.orderStatusCB.Name = "orderStatusCB";
            this.orderStatusCB.Size = new System.Drawing.Size(126, 17);
            this.orderStatusCB.TabIndex = 5;
            this.orderStatusCB.Text = "Use as Leader Board";
            this.orderStatusCB.UseVisualStyleBackColor = true;
            this.orderStatusCB.Visible = false;
            // 
            // observersGroup
            // 
            this.observersGroup.Controls.Add(this.athleteStatusRB);
            this.observersGroup.Controls.Add(this.athleteCompareRB);
            this.observersGroup.Controls.Add(this.singleAthleteTrackerRB);
            this.observersGroup.Controls.Add(this.emailRB);
            this.observersGroup.Location = new System.Drawing.Point(12, 12);
            this.observersGroup.Name = "observersGroup";
            this.observersGroup.Size = new System.Drawing.Size(200, 116);
            this.observersGroup.TabIndex = 6;
            this.observersGroup.TabStop = false;
            this.observersGroup.Text = "Observers";
            // 
            // athlete1ComboBox
            // 
            this.athlete1ComboBox.FormattingEnabled = true;
            this.athlete1ComboBox.Location = new System.Drawing.Point(297, 54);
            this.athlete1ComboBox.Name = "athlete1ComboBox";
            this.athlete1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.athlete1ComboBox.TabIndex = 7;
            this.athlete1ComboBox.Visible = false;
            this.athlete1ComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.athlete1ComboBox_MouseClick);
            // 
            // athlete2ComboBox
            // 
            this.athlete2ComboBox.FormattingEnabled = true;
            this.athlete2ComboBox.Location = new System.Drawing.Point(297, 81);
            this.athlete2ComboBox.Name = "athlete2ComboBox";
            this.athlete2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.athlete2ComboBox.TabIndex = 8;
            this.athlete2ComboBox.Visible = false;
            // 
            // athlete1Label
            // 
            this.athlete1Label.AutoSize = true;
            this.athlete1Label.Location = new System.Drawing.Point(218, 57);
            this.athlete1Label.Name = "athlete1Label";
            this.athlete1Label.Size = new System.Drawing.Size(73, 13);
            this.athlete1Label.TabIndex = 9;
            this.athlete1Label.Text = "Select Athlete";
            // 
            // athlete2Label
            // 
            this.athlete2Label.AutoSize = true;
            this.athlete2Label.Location = new System.Drawing.Point(218, 84);
            this.athlete2Label.Name = "athlete2Label";
            this.athlete2Label.Size = new System.Drawing.Size(73, 13);
            this.athlete2Label.TabIndex = 10;
            this.athlete2Label.Text = "Select Athlete";
            // 
            // ObserverCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 187);
            this.Controls.Add(this.athlete2Label);
            this.Controls.Add(this.athlete1Label);
            this.Controls.Add(this.athlete2ComboBox);
            this.Controls.Add(this.athlete1ComboBox);
            this.Controls.Add(this.observersGroup);
            this.Controls.Add(this.orderStatusCB);
            this.Controls.Add(this.createBtn);
            this.Name = "ObserverCreator";
            this.Text = "ObserverCreator";
            this.observersGroup.ResumeLayout(false);
            this.observersGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton athleteStatusRB;
        private System.Windows.Forms.RadioButton athleteCompareRB;
        private System.Windows.Forms.RadioButton singleAthleteTrackerRB;
        private System.Windows.Forms.RadioButton emailRB;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.CheckBox orderStatusCB;
        private System.Windows.Forms.GroupBox observersGroup;
        private System.Windows.Forms.ComboBox athlete1ComboBox;
        private System.Windows.Forms.ComboBox athlete2ComboBox;
        private System.Windows.Forms.Label athlete1Label;
        private System.Windows.Forms.Label athlete2Label;
    }
}