using RaceDataProcessor;

namespace RaceMonitor
{
    class ComparisonObserver : AthleteObserver
    {
        private System.Windows.Forms.ComboBox athlete1ComboBox;
        private System.Windows.Forms.ComboBox athlete2ComboBox;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.ListBox athlete1ListBox;
        private System.Windows.Forms.ListBox athlete2ListBox;

        private void InitializeComponent()
        {
            this.athlete1ComboBox = new System.Windows.Forms.ComboBox();
            this.athlete2ComboBox = new System.Windows.Forms.ComboBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.athlete1ListBox = new System.Windows.Forms.ListBox();
            this.athlete2ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // athlete1ComboBox
            // 
            this.athlete1ComboBox.FormattingEnabled = true;
            this.athlete1ComboBox.Location = new System.Drawing.Point(51, 37);
            this.athlete1ComboBox.Name = "athlete1ComboBox";
            this.athlete1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.athlete1ComboBox.TabIndex = 0;
            // 
            // athlete2ComboBox
            // 
            this.athlete2ComboBox.FormattingEnabled = true;
            this.athlete2ComboBox.Location = new System.Drawing.Point(206, 37);
            this.athlete2ComboBox.Name = "athlete2ComboBox";
            this.athlete2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.athlete2ComboBox.TabIndex = 1;
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(51, 94);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(75, 23);
            this.compareBtn.TabIndex = 2;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            // 
            // athlete1ListBox
            // 
            this.athlete1ListBox.FormattingEnabled = true;
            this.athlete1ListBox.Location = new System.Drawing.Point(51, 143);
            this.athlete1ListBox.Name = "athlete1ListBox";
            this.athlete1ListBox.Size = new System.Drawing.Size(120, 225);
            this.athlete1ListBox.TabIndex = 3;
            // 
            // athlete2ListBox
            // 
            this.athlete2ListBox.FormattingEnabled = true;
            this.athlete2ListBox.Location = new System.Drawing.Point(206, 143);
            this.athlete2ListBox.Name = "athlete2ListBox";
            this.athlete2ListBox.Size = new System.Drawing.Size(120, 225);
            this.athlete2ListBox.TabIndex = 4;
            // 
            // ComparisonObserver
            // 
            this.ClientSize = new System.Drawing.Size(371, 414);
            this.Controls.Add(this.athlete2ListBox);
            this.Controls.Add(this.athlete1ListBox);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.athlete2ComboBox);
            this.Controls.Add(this.athlete1ComboBox);
            this.Name = "ComparisonObserver";
            this.ResumeLayout(false);

        }
    }
}
