namespace RaceMonitor
{
    partial class ComparisonObserver
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.athlete1ListBox = new System.Windows.Forms.ListView();
            this.athlete2ListBox = new System.Windows.Forms.ListView();
            this.distance2Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time2Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distance1Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time1Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.athlete1BibText = new System.Windows.Forms.TextBox();
            this.athlete1LastNameText = new System.Windows.Forms.TextBox();
            this.athlete1FirstNameText = new System.Windows.Forms.TextBox();
            this.athlete2BibText = new System.Windows.Forms.TextBox();
            this.athlete2FirstNameText = new System.Windows.Forms.TextBox();
            this.athlete2LastNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bib Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bib Number:";
            // 
            // athlete1ListBox
            // 
            this.athlete1ListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.distance1Column,
            this.time1Column});
            this.athlete1ListBox.Location = new System.Drawing.Point(12, 111);
            this.athlete1ListBox.Name = "athlete1ListBox";
            this.athlete1ListBox.Size = new System.Drawing.Size(169, 276);
            this.athlete1ListBox.TabIndex = 11;
            this.athlete1ListBox.UseCompatibleStateImageBehavior = false;
            // 
            // athlete2ListBox
            // 
            this.athlete2ListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.distance2Column,
            this.time2Column});
            this.athlete2ListBox.Location = new System.Drawing.Point(258, 111);
            this.athlete2ListBox.Name = "athlete2ListBox";
            this.athlete2ListBox.Size = new System.Drawing.Size(169, 276);
            this.athlete2ListBox.TabIndex = 12;
            this.athlete2ListBox.UseCompatibleStateImageBehavior = false;
            // 
            // athlete1BibText
            // 
            this.athlete1BibText.Location = new System.Drawing.Point(104, 6);
            this.athlete1BibText.Name = "athlete1BibText";
            this.athlete1BibText.Size = new System.Drawing.Size(77, 22);
            this.athlete1BibText.TabIndex = 13;
            // 
            // athlete1LastNameText
            // 
            this.athlete1LastNameText.Location = new System.Drawing.Point(104, 62);
            this.athlete1LastNameText.Name = "athlete1LastNameText";
            this.athlete1LastNameText.Size = new System.Drawing.Size(77, 22);
            this.athlete1LastNameText.TabIndex = 14;
            // 
            // athlete1FirstNameText
            // 
            this.athlete1FirstNameText.Location = new System.Drawing.Point(104, 34);
            this.athlete1FirstNameText.Name = "athlete1FirstNameText";
            this.athlete1FirstNameText.Size = new System.Drawing.Size(77, 22);
            this.athlete1FirstNameText.TabIndex = 15;
            // 
            // athlete2BibText
            // 
            this.athlete2BibText.Location = new System.Drawing.Point(350, 6);
            this.athlete2BibText.Name = "athlete2BibText";
            this.athlete2BibText.Size = new System.Drawing.Size(77, 22);
            this.athlete2BibText.TabIndex = 16;
            // 
            // athlete2FirstNameText
            // 
            this.athlete2FirstNameText.Location = new System.Drawing.Point(350, 34);
            this.athlete2FirstNameText.Name = "athlete2FirstNameText";
            this.athlete2FirstNameText.Size = new System.Drawing.Size(77, 22);
            this.athlete2FirstNameText.TabIndex = 17;
            // 
            // athlete2LastNameText
            // 
            this.athlete2LastNameText.Location = new System.Drawing.Point(350, 62);
            this.athlete2LastNameText.Name = "athlete2LastNameText";
            this.athlete2LastNameText.Size = new System.Drawing.Size(77, 22);
            this.athlete2LastNameText.TabIndex = 18;
            // 
            // ComparisonObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 414);
            this.Controls.Add(this.athlete2LastNameText);
            this.Controls.Add(this.athlete2FirstNameText);
            this.Controls.Add(this.athlete2BibText);
            this.Controls.Add(this.athlete1FirstNameText);
            this.Controls.Add(this.athlete1LastNameText);
            this.Controls.Add(this.athlete1BibText);
            this.Controls.Add(this.athlete2ListBox);
            this.Controls.Add(this.athlete1ListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ComparisonObserver";
            this.Text = "Athlete Comparison Observer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView athlete1ListBox;
        private System.Windows.Forms.ColumnHeader distance1Column;
        private System.Windows.Forms.ColumnHeader time1Column;
        private System.Windows.Forms.ListView athlete2ListBox;
        private System.Windows.Forms.ColumnHeader distance2Column;
        private System.Windows.Forms.ColumnHeader time2Column;
        private System.Windows.Forms.TextBox athlete1BibText;
        private System.Windows.Forms.TextBox athlete1LastNameText;
        private System.Windows.Forms.TextBox athlete1FirstNameText;
        private System.Windows.Forms.TextBox athlete2BibText;
        private System.Windows.Forms.TextBox athlete2FirstNameText;
        private System.Windows.Forms.TextBox athlete2LastNameText;
    }
}