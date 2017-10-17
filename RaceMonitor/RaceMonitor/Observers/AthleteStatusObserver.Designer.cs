namespace RaceMonitor
{
    partial class AthleteStatusObserver
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
            this.athleteStatusListBox = new System.Windows.Forms.ListView();
            this.bibNumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // athleteStatusListBox
            // 
            this.athleteStatusListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bibNumCol,
            this.firstNameCol,
            this.lastNameCol,
            this.statusCol});
            this.athleteStatusListBox.GridLines = true;
            this.athleteStatusListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.athleteStatusListBox.Location = new System.Drawing.Point(31, 31);
            this.athleteStatusListBox.Name = "athleteStatusListBox";
            this.athleteStatusListBox.Size = new System.Drawing.Size(371, 318);
            this.athleteStatusListBox.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.athleteStatusListBox.TabIndex = 0;
            this.athleteStatusListBox.UseCompatibleStateImageBehavior = false;
            this.athleteStatusListBox.View = System.Windows.Forms.View.Details;
            // 
            // bibNumCol
            // 
            this.bibNumCol.Text = "Bib Number";
            this.bibNumCol.Width = 72;
            // 
            // firstNameCol
            // 
            this.firstNameCol.Text = "First Name";
            this.firstNameCol.Width = 87;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Text = "Last Name";
            this.lastNameCol.Width = 92;
            // 
            // statusCol
            // 
            this.statusCol.Text = "Status";
            this.statusCol.Width = 139;
            // 
            // AthleteStatusObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 384);
            this.Controls.Add(this.athleteStatusListBox);
            this.Name = "AthleteStatusObserver";
            this.Text = "Athlete Status";
            this.Load += new System.EventHandler(this.AthleteStatusObserver_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView athleteStatusListBox;
        private System.Windows.Forms.ColumnHeader bibNumCol;
        private System.Windows.Forms.ColumnHeader firstNameCol;
        private System.Windows.Forms.ColumnHeader lastNameCol;
        private System.Windows.Forms.ColumnHeader statusCol;
    }
}