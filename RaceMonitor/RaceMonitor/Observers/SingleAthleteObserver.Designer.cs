namespace RaceMonitor
{
    partial class SingleAthleteObserver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.athleteBibText = new System.Windows.Forms.TextBox();
            this.athleteFirstNameText = new System.Windows.Forms.TextBox();
            this.athleteLastNameText = new System.Windows.Forms.TextBox();
            this.athleteTrackingListBox = new System.Windows.Forms.ListView();
            this.timeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distanceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bib Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // athleteBibText
            // 
            this.athleteBibText.Location = new System.Drawing.Point(115, 34);
            this.athleteBibText.Name = "athleteBibText";
            this.athleteBibText.Size = new System.Drawing.Size(182, 22);
            this.athleteBibText.TabIndex = 3;
            // 
            // athleteFirstNameText
            // 
            this.athleteFirstNameText.Location = new System.Drawing.Point(115, 61);
            this.athleteFirstNameText.Name = "athleteFirstNameText";
            this.athleteFirstNameText.Size = new System.Drawing.Size(182, 22);
            this.athleteFirstNameText.TabIndex = 4;
            // 
            // athleteLastNameText
            // 
            this.athleteLastNameText.Location = new System.Drawing.Point(115, 90);
            this.athleteLastNameText.Name = "athleteLastNameText";
            this.athleteLastNameText.Size = new System.Drawing.Size(182, 22);
            this.athleteLastNameText.TabIndex = 5;
            // 
            // athleteTrackingListBox
            // 
            this.athleteTrackingListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.distanceColumn,
            this.timeColumn});
            this.athleteTrackingListBox.Location = new System.Drawing.Point(26, 142);
            this.athleteTrackingListBox.Name = "athleteTrackingListBox";
            this.athleteTrackingListBox.Size = new System.Drawing.Size(271, 332);
            this.athleteTrackingListBox.TabIndex = 6;
            this.athleteTrackingListBox.UseCompatibleStateImageBehavior = false;
            this.athleteTrackingListBox.View = System.Windows.Forms.View.Details;
            // 
            // timeColumn
            // 
            this.timeColumn.Text = "Time";
            this.timeColumn.Width = 117;
            // 
            // distanceColumn
            // 
            this.distanceColumn.Text = "Distance";
            this.distanceColumn.Width = 125;
            // 
            // SingleAthleteObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 486);
            this.Controls.Add(this.athleteTrackingListBox);
            this.Controls.Add(this.athleteLastNameText);
            this.Controls.Add(this.athleteFirstNameText);
            this.Controls.Add(this.athleteBibText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SingleAthleteObserver";
            this.Text = "SingleAthleteObserver";
            this.Load += new System.EventHandler(this.SingleAthleteObserver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox athleteBibText;
        private System.Windows.Forms.TextBox athleteFirstNameText;
        private System.Windows.Forms.TextBox athleteLastNameText;
        private System.Windows.Forms.ListView athleteTrackingListBox;
        private System.Windows.Forms.ColumnHeader distanceColumn;
        private System.Windows.Forms.ColumnHeader timeColumn;
    }
}