namespace RaceMonitor
{
    partial class MainRaceForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.runSimBtn = new System.Windows.Forms.Button();
            this.simInfoGroup = new System.Windows.Forms.GroupBox();
            this.raceCourseComboBox = new System.Windows.Forms.ComboBox();
            this.observerGroup = new System.Windows.Forms.GroupBox();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.courseDistanceTextBox = new System.Windows.Forms.TextBox();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.eventTitleTextBox = new System.Windows.Forms.TextBox();
            this.eventDateTextBox = new System.Windows.Forms.TextBox();
            this.eventTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.observerListBox = new System.Windows.Forms.ListBox();
            this.startObserversBtn = new System.Windows.Forms.Button();
            this.statusObserverCheckBox = new System.Windows.Forms.CheckBox();
            this.leaderBoardCheckBox = new System.Windows.Forms.CheckBox();
            this.emailObserverCheckBox = new System.Windows.Forms.CheckBox();
            this.compareObserverCheckBox = new System.Windows.Forms.CheckBox();
            this.simInfoGroup.SuspendLayout();
            this.observerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(372, 390);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(56, 19);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // runSimBtn
            // 
            this.runSimBtn.Location = new System.Drawing.Point(49, 318);
            this.runSimBtn.Name = "runSimBtn";
            this.runSimBtn.Size = new System.Drawing.Size(102, 23);
            this.runSimBtn.TabIndex = 2;
            this.runSimBtn.Text = "Run Simulation";
            this.runSimBtn.UseVisualStyleBackColor = true;
            this.runSimBtn.Click += new System.EventHandler(this.runSimBtn_Click);
            // 
            // simInfoGroup
            // 
            this.simInfoGroup.Controls.Add(this.label7);
            this.simInfoGroup.Controls.Add(this.label6);
            this.simInfoGroup.Controls.Add(this.label5);
            this.simInfoGroup.Controls.Add(this.label4);
            this.simInfoGroup.Controls.Add(this.label3);
            this.simInfoGroup.Controls.Add(this.label2);
            this.simInfoGroup.Controls.Add(this.label1);
            this.simInfoGroup.Controls.Add(this.eventTimeTextBox);
            this.simInfoGroup.Controls.Add(this.eventDateTextBox);
            this.simInfoGroup.Controls.Add(this.eventTitleTextBox);
            this.simInfoGroup.Controls.Add(this.eventIdTextBox);
            this.simInfoGroup.Controls.Add(this.courseDistanceTextBox);
            this.simInfoGroup.Controls.Add(this.courseIdTextBox);
            this.simInfoGroup.Controls.Add(this.raceCourseComboBox);
            this.simInfoGroup.Controls.Add(this.runSimBtn);
            this.simInfoGroup.Location = new System.Drawing.Point(12, 26);
            this.simInfoGroup.Name = "simInfoGroup";
            this.simInfoGroup.Size = new System.Drawing.Size(200, 347);
            this.simInfoGroup.TabIndex = 3;
            this.simInfoGroup.TabStop = false;
            this.simInfoGroup.Text = "Simulation Information";
            // 
            // raceCourseComboBox
            // 
            this.raceCourseComboBox.FormattingEnabled = true;
            this.raceCourseComboBox.Items.AddRange(new object[] {
            "Century Race Course",
            "Short Race Course"});
            this.raceCourseComboBox.Location = new System.Drawing.Point(73, 31);
            this.raceCourseComboBox.Name = "raceCourseComboBox";
            this.raceCourseComboBox.Size = new System.Drawing.Size(121, 21);
            this.raceCourseComboBox.TabIndex = 3;
            this.raceCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.raceCourseComboBox_SelectedIndexChanged);
            // 
            // observerGroup
            // 
            this.observerGroup.Controls.Add(this.compareObserverCheckBox);
            this.observerGroup.Controls.Add(this.emailObserverCheckBox);
            this.observerGroup.Controls.Add(this.leaderBoardCheckBox);
            this.observerGroup.Controls.Add(this.statusObserverCheckBox);
            this.observerGroup.Controls.Add(this.startObserversBtn);
            this.observerGroup.Controls.Add(this.observerListBox);
            this.observerGroup.Location = new System.Drawing.Point(234, 26);
            this.observerGroup.Name = "observerGroup";
            this.observerGroup.Size = new System.Drawing.Size(200, 347);
            this.observerGroup.TabIndex = 4;
            this.observerGroup.TabStop = false;
            this.observerGroup.Text = "Race Observers";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(73, 69);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.ReadOnly = true;
            this.courseIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIdTextBox.TabIndex = 4;
            // 
            // courseDistanceTextBox
            // 
            this.courseDistanceTextBox.Location = new System.Drawing.Point(73, 105);
            this.courseDistanceTextBox.Name = "courseDistanceTextBox";
            this.courseDistanceTextBox.ReadOnly = true;
            this.courseDistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseDistanceTextBox.TabIndex = 5;
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.Location = new System.Drawing.Point(73, 167);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventIdTextBox.TabIndex = 6;
            // 
            // eventTitleTextBox
            // 
            this.eventTitleTextBox.Location = new System.Drawing.Point(73, 206);
            this.eventTitleTextBox.Name = "eventTitleTextBox";
            this.eventTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventTitleTextBox.TabIndex = 7;
            // 
            // eventDateTextBox
            // 
            this.eventDateTextBox.Location = new System.Drawing.Point(73, 245);
            this.eventDateTextBox.Name = "eventDateTextBox";
            this.eventDateTextBox.ReadOnly = true;
            this.eventDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventDateTextBox.TabIndex = 8;
            // 
            // eventTimeTextBox
            // 
            this.eventTimeTextBox.Location = new System.Drawing.Point(73, 282);
            this.eventTimeTextBox.Name = "eventTimeTextBox";
            this.eventTimeTextBox.ReadOnly = true;
            this.eventTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventTimeTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Event Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Event Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Event Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Event Time:";
            // 
            // observerListBox
            // 
            this.observerListBox.FormattingEnabled = true;
            this.observerListBox.Location = new System.Drawing.Point(6, 30);
            this.observerListBox.Name = "observerListBox";
            this.observerListBox.Size = new System.Drawing.Size(188, 121);
            this.observerListBox.TabIndex = 0;
            // 
            // startObserversBtn
            // 
            this.startObserversBtn.Location = new System.Drawing.Point(56, 318);
            this.startObserversBtn.Name = "startObserversBtn";
            this.startObserversBtn.Size = new System.Drawing.Size(97, 23);
            this.startObserversBtn.TabIndex = 1;
            this.startObserversBtn.Text = "Show Observers";
            this.startObserversBtn.UseVisualStyleBackColor = true;
            this.startObserversBtn.Click += new System.EventHandler(this.startObserversBtn_Click);
            // 
            // statusObserverCheckBox
            // 
            this.statusObserverCheckBox.AutoSize = true;
            this.statusObserverCheckBox.Location = new System.Drawing.Point(15, 169);
            this.statusObserverCheckBox.Name = "statusObserverCheckBox";
            this.statusObserverCheckBox.Size = new System.Drawing.Size(138, 17);
            this.statusObserverCheckBox.TabIndex = 2;
            this.statusObserverCheckBox.Text = "Athlete Status Observer";
            this.statusObserverCheckBox.UseVisualStyleBackColor = true;
            // 
            // leaderBoardCheckBox
            // 
            this.leaderBoardCheckBox.AutoSize = true;
            this.leaderBoardCheckBox.Location = new System.Drawing.Point(15, 192);
            this.leaderBoardCheckBox.Name = "leaderBoardCheckBox";
            this.leaderBoardCheckBox.Size = new System.Drawing.Size(136, 17);
            this.leaderBoardCheckBox.TabIndex = 3;
            this.leaderBoardCheckBox.Text = "Leader Board Observer";
            this.leaderBoardCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailObserverCheckBox
            // 
            this.emailObserverCheckBox.AutoSize = true;
            this.emailObserverCheckBox.Location = new System.Drawing.Point(15, 215);
            this.emailObserverCheckBox.Name = "emailObserverCheckBox";
            this.emailObserverCheckBox.Size = new System.Drawing.Size(97, 17);
            this.emailObserverCheckBox.TabIndex = 4;
            this.emailObserverCheckBox.Text = "Email Observer";
            this.emailObserverCheckBox.UseVisualStyleBackColor = true;
            // 
            // compareObserverCheckBox
            // 
            this.compareObserverCheckBox.AutoSize = true;
            this.compareObserverCheckBox.Location = new System.Drawing.Point(15, 238);
            this.compareObserverCheckBox.Name = "compareObserverCheckBox";
            this.compareObserverCheckBox.Size = new System.Drawing.Size(127, 17);
            this.compareObserverCheckBox.TabIndex = 5;
            this.compareObserverCheckBox.Text = "Comparison Observer";
            this.compareObserverCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 426);
            this.Controls.Add(this.observerGroup);
            this.Controls.Add(this.simInfoGroup);
            this.Controls.Add(this.exitBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainRaceForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainRaceForm_FormClosing);
            this.simInfoGroup.ResumeLayout(false);
            this.simInfoGroup.PerformLayout();
            this.observerGroup.ResumeLayout(false);
            this.observerGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button runSimBtn;
        private System.Windows.Forms.GroupBox observerGroup;
        private System.Windows.Forms.GroupBox simInfoGroup;
        private System.Windows.Forms.ComboBox raceCourseComboBox;
        private System.Windows.Forms.TextBox eventTimeTextBox;
        private System.Windows.Forms.TextBox eventDateTextBox;
        private System.Windows.Forms.TextBox eventTitleTextBox;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.TextBox courseDistanceTextBox;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox compareObserverCheckBox;
        private System.Windows.Forms.CheckBox emailObserverCheckBox;
        private System.Windows.Forms.CheckBox leaderBoardCheckBox;
        private System.Windows.Forms.CheckBox statusObserverCheckBox;
        private System.Windows.Forms.Button startObserversBtn;
        private System.Windows.Forms.ListBox observerListBox;
    }
}

