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
            this.observersGroup = new System.Windows.Forms.GroupBox();
            this.athlete1ComboBox = new System.Windows.Forms.ComboBox();
            this.athlete2ComboBox = new System.Windows.Forms.ComboBox();
            this.athlete1Label = new System.Windows.Forms.Label();
            this.athlete2Label = new System.Windows.Forms.Label();
            this.athleteGroupBox = new System.Windows.Forms.GroupBox();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.ageCB = new System.Windows.Forms.CheckBox();
            this.observersGroup.SuspendLayout();
            this.athleteGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // athleteStatusRB
            // 
            this.athleteStatusRB.AutoSize = true;
            this.athleteStatusRB.Location = new System.Drawing.Point(8, 23);
            this.athleteStatusRB.Margin = new System.Windows.Forms.Padding(4);
            this.athleteStatusRB.Name = "athleteStatusRB";
            this.athleteStatusRB.Size = new System.Drawing.Size(168, 21);
            this.athleteStatusRB.TabIndex = 0;
            this.athleteStatusRB.TabStop = true;
            this.athleteStatusRB.Text = "Athlete Status Creator";
            this.athleteStatusRB.UseVisualStyleBackColor = true;
            this.athleteStatusRB.CheckedChanged += new System.EventHandler(this.athleteStatusRB_CheckedChanged);
            // 
            // athleteCompareRB
            // 
            this.athleteCompareRB.AutoSize = true;
            this.athleteCompareRB.Location = new System.Drawing.Point(8, 52);
            this.athleteCompareRB.Margin = new System.Windows.Forms.Padding(4);
            this.athleteCompareRB.Name = "athleteCompareRB";
            this.athleteCompareRB.Size = new System.Drawing.Size(215, 21);
            this.athleteCompareRB.TabIndex = 1;
            this.athleteCompareRB.TabStop = true;
            this.athleteCompareRB.Text = "Athlete Comparison Observer";
            this.athleteCompareRB.UseVisualStyleBackColor = true;
            this.athleteCompareRB.CheckedChanged += new System.EventHandler(this.athleteCompareRB_CheckedChanged);
            // 
            // singleAthleteTrackerRB
            // 
            this.singleAthleteTrackerRB.AutoSize = true;
            this.singleAthleteTrackerRB.Location = new System.Drawing.Point(8, 80);
            this.singleAthleteTrackerRB.Margin = new System.Windows.Forms.Padding(4);
            this.singleAthleteTrackerRB.Name = "singleAthleteTrackerRB";
            this.singleAthleteTrackerRB.Size = new System.Drawing.Size(179, 21);
            this.singleAthleteTrackerRB.TabIndex = 2;
            this.singleAthleteTrackerRB.TabStop = true;
            this.singleAthleteTrackerRB.Text = "Single Athlete Observer";
            this.singleAthleteTrackerRB.UseVisualStyleBackColor = true;
            this.singleAthleteTrackerRB.CheckedChanged += new System.EventHandler(this.singleAthleteTrackerRB_CheckedChanged);
            // 
            // emailRB
            // 
            this.emailRB.AutoSize = true;
            this.emailRB.Location = new System.Drawing.Point(8, 108);
            this.emailRB.Margin = new System.Windows.Forms.Padding(4);
            this.emailRB.Name = "emailRB";
            this.emailRB.Size = new System.Drawing.Size(126, 21);
            this.emailRB.TabIndex = 3;
            this.emailRB.TabStop = true;
            this.emailRB.Text = "Email Observer";
            this.emailRB.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(16, 165);
            this.createBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(100, 28);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // observersGroup
            // 
            this.observersGroup.Controls.Add(this.athleteStatusRB);
            this.observersGroup.Controls.Add(this.athleteCompareRB);
            this.observersGroup.Controls.Add(this.singleAthleteTrackerRB);
            this.observersGroup.Controls.Add(this.emailRB);
            this.observersGroup.Location = new System.Drawing.Point(16, 15);
            this.observersGroup.Margin = new System.Windows.Forms.Padding(4);
            this.observersGroup.Name = "observersGroup";
            this.observersGroup.Padding = new System.Windows.Forms.Padding(4);
            this.observersGroup.Size = new System.Drawing.Size(267, 143);
            this.observersGroup.TabIndex = 6;
            this.observersGroup.TabStop = false;
            this.observersGroup.Text = "Observers";
            // 
            // athlete1ComboBox
            // 
            this.athlete1ComboBox.FormattingEnabled = true;
            this.athlete1ComboBox.Location = new System.Drawing.Point(132, 27);
            this.athlete1ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.athlete1ComboBox.Name = "athlete1ComboBox";
            this.athlete1ComboBox.Size = new System.Drawing.Size(160, 24);
            this.athlete1ComboBox.TabIndex = 7;
            this.athlete1ComboBox.Visible = false;
            this.athlete1ComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.athlete1ComboBox_MouseClick);
            // 
            // athlete2ComboBox
            // 
            this.athlete2ComboBox.FormattingEnabled = true;
            this.athlete2ComboBox.Location = new System.Drawing.Point(132, 61);
            this.athlete2ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.athlete2ComboBox.Name = "athlete2ComboBox";
            this.athlete2ComboBox.Size = new System.Drawing.Size(160, 24);
            this.athlete2ComboBox.TabIndex = 8;
            this.athlete2ComboBox.Visible = false;
            // 
            // athlete1Label
            // 
            this.athlete1Label.AutoSize = true;
            this.athlete1Label.Location = new System.Drawing.Point(27, 31);
            this.athlete1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.athlete1Label.Name = "athlete1Label";
            this.athlete1Label.Size = new System.Drawing.Size(95, 17);
            this.athlete1Label.TabIndex = 9;
            this.athlete1Label.Text = "Select Athlete";
            this.athlete1Label.Visible = false;
            // 
            // athlete2Label
            // 
            this.athlete2Label.AutoSize = true;
            this.athlete2Label.Location = new System.Drawing.Point(27, 64);
            this.athlete2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.athlete2Label.Name = "athlete2Label";
            this.athlete2Label.Size = new System.Drawing.Size(95, 17);
            this.athlete2Label.TabIndex = 10;
            this.athlete2Label.Text = "Select Athlete";
            this.athlete2Label.Visible = false;
            // 
            // athleteGroupBox
            // 
            this.athleteGroupBox.Controls.Add(this.athlete1Label);
            this.athleteGroupBox.Controls.Add(this.athlete2Label);
            this.athleteGroupBox.Controls.Add(this.athlete1ComboBox);
            this.athleteGroupBox.Controls.Add(this.athlete2ComboBox);
            this.athleteGroupBox.Location = new System.Drawing.Point(305, 16);
            this.athleteGroupBox.Name = "athleteGroupBox";
            this.athleteGroupBox.Size = new System.Drawing.Size(304, 142);
            this.athleteGroupBox.TabIndex = 11;
            this.athleteGroupBox.TabStop = false;
            this.athleteGroupBox.Text = "Athlete Selection";
            this.athleteGroupBox.Visible = false;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.ageCB);
            this.statusGroupBox.Location = new System.Drawing.Point(615, 16);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(186, 143);
            this.statusGroupBox.TabIndex = 12;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Additional Information";
            this.statusGroupBox.Visible = false;
            // 
            // ageCB
            // 
            this.ageCB.AutoSize = true;
            this.ageCB.Location = new System.Drawing.Point(6, 30);
            this.ageCB.Name = "ageCB";
            this.ageCB.Size = new System.Drawing.Size(55, 21);
            this.ageCB.TabIndex = 8;
            this.ageCB.Text = "Age";
            this.ageCB.UseVisualStyleBackColor = true;
            // 
            // ObserverCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 230);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.athleteGroupBox);
            this.Controls.Add(this.observersGroup);
            this.Controls.Add(this.createBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ObserverCreator";
            this.Text = "ObserverCreator";
            this.observersGroup.ResumeLayout(false);
            this.observersGroup.PerformLayout();
            this.athleteGroupBox.ResumeLayout(false);
            this.athleteGroupBox.PerformLayout();
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton athleteStatusRB;
        private System.Windows.Forms.RadioButton athleteCompareRB;
        private System.Windows.Forms.RadioButton singleAthleteTrackerRB;
        private System.Windows.Forms.RadioButton emailRB;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.GroupBox observersGroup;
        private System.Windows.Forms.ComboBox athlete1ComboBox;
        private System.Windows.Forms.ComboBox athlete2ComboBox;
        private System.Windows.Forms.Label athlete1Label;
        private System.Windows.Forms.Label athlete2Label;
        private System.Windows.Forms.GroupBox athleteGroupBox;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.CheckBox ageCB;
    }
}