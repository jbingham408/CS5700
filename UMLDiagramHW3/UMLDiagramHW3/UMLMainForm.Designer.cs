namespace UmlDiagramHW3
{
    partial class UMLMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDiagramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadDiagramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDiagramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.DiagramPanel = new System.Windows.Forms.Panel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectorToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.ClassToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.GenSpecToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.AggregationToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.CompositionToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.DependencyToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.BinaryToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.ComponentsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDiagramMenuItem,
            this.LoadDiagramMenuItem,
            this.SaveDiagramMenuItem,
            this.toolStripSeparator1,
            this.QuitAppMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(44, 24);
            this.FileMenu.Text = "File";
            // 
            // NewDiagramMenuItem
            // 
            this.NewDiagramMenuItem.Name = "NewDiagramMenuItem";
            this.NewDiagramMenuItem.Size = new System.Drawing.Size(117, 26);
            this.NewDiagramMenuItem.Text = "New";
            // 
            // LoadDiagramMenuItem
            // 
            this.LoadDiagramMenuItem.Name = "LoadDiagramMenuItem";
            this.LoadDiagramMenuItem.Size = new System.Drawing.Size(117, 26);
            this.LoadDiagramMenuItem.Text = "Load";
            // 
            // SaveDiagramMenuItem
            // 
            this.SaveDiagramMenuItem.Name = "SaveDiagramMenuItem";
            this.SaveDiagramMenuItem.Size = new System.Drawing.Size(117, 26);
            this.SaveDiagramMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // QuitAppMenuItem
            // 
            this.QuitAppMenuItem.Name = "QuitAppMenuItem";
            this.QuitAppMenuItem.Size = new System.Drawing.Size(117, 26);
            this.QuitAppMenuItem.Text = "Exit";
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenuItem});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(47, 24);
            this.EditMenu.Text = "Edit";
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Name = "UndoMenuItem";
            this.UndoMenuItem.Size = new System.Drawing.Size(120, 26);
            this.UndoMenuItem.Text = "Undo";
            // 
            // ComponentsToolStrip
            // 
            this.ComponentsToolStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ComponentsToolStrip.CanOverflow = false;
            this.ComponentsToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.ComponentsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ComponentsToolStrip.ImageScalingSize = new System.Drawing.Size(90, 70);
            this.ComponentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectorToolStripBtn,
            this.toolStripSeparator2,
            this.ClassToolStripBtn,
            this.GenSpecToolStripBtn,
            this.AggregationToolStripBtn,
            this.CompositionToolStripBtn,
            this.DependencyToolStripBtn,
            this.BinaryToolStripBtn});
            this.ComponentsToolStrip.Location = new System.Drawing.Point(0, 28);
            this.ComponentsToolStrip.Name = "ComponentsToolStrip";
            this.ComponentsToolStrip.Size = new System.Drawing.Size(95, 675);
            this.ComponentsToolStrip.TabIndex = 1;
            this.ComponentsToolStrip.Text = "toolStrip1";
            // 
            // DiagramPanel
            // 
            this.DiagramPanel.AutoScroll = true;
            this.DiagramPanel.AutoSize = true;
            this.DiagramPanel.BackColor = System.Drawing.SystemColors.Window;
            this.DiagramPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiagramPanel.Location = new System.Drawing.Point(95, 28);
            this.DiagramPanel.Margin = new System.Windows.Forms.Padding(10);
            this.DiagramPanel.Name = "DiagramPanel";
            this.DiagramPanel.Padding = new System.Windows.Forms.Padding(10);
            this.DiagramPanel.Size = new System.Drawing.Size(987, 675);
            this.DiagramPanel.TabIndex = 2;
            this.DiagramPanel.UseWaitCursor = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(77, 6);
            // 
            // SelectorToolStripBtn
            // 
            this.SelectorToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectorToolStripBtn.Image = global::UmlDiagramHW3.Properties.Resources.cursor_png_1102;
            this.SelectorToolStripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SelectorToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectorToolStripBtn.Name = "SelectorToolStripBtn";
            this.SelectorToolStripBtn.Size = new System.Drawing.Size(77, 54);
            this.SelectorToolStripBtn.Text = "Selector";
            // 
            // ClassToolStripBtn
            // 
            this.ClassToolStripBtn.CheckOnClick = true;
            this.ClassToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClassToolStripBtn.Image = global::UmlDiagramHW3.Properties.Resources.Class;
            this.ClassToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClassToolStripBtn.Name = "ClassToolStripBtn";
            this.ClassToolStripBtn.Size = new System.Drawing.Size(77, 79);
            this.ClassToolStripBtn.Text = "Class";
            this.ClassToolStripBtn.Click += new System.EventHandler(this.ClassToolStripBtn_Click);
            // 
            // GenSpecToolStripBtn
            // 
            this.GenSpecToolStripBtn.CheckOnClick = true;
            this.GenSpecToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GenSpecToolStripBtn.Image = global::UmlDiagramHW3.Properties.Resources.GenSpec;
            this.GenSpecToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GenSpecToolStripBtn.Name = "GenSpecToolStripBtn";
            this.GenSpecToolStripBtn.Size = new System.Drawing.Size(77, 79);
            this.GenSpecToolStripBtn.Text = "Generalization/Specialization";
            this.GenSpecToolStripBtn.Click += new System.EventHandler(this.GenSpecToolStripBtn_Click);
            // 
            // AggregationToolStripBtn
            // 
            this.AggregationToolStripBtn.CheckOnClick = true;
            this.AggregationToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AggregationToolStripBtn.Image = global::UmlDiagramHW3.Properties.Resources.Aggregation;
            this.AggregationToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AggregationToolStripBtn.Name = "AggregationToolStripBtn";
            this.AggregationToolStripBtn.Size = new System.Drawing.Size(77, 79);
            this.AggregationToolStripBtn.Text = "Aggregation";
            this.AggregationToolStripBtn.Click += new System.EventHandler(this.AggregationToolStripBtn_Click);
            // 
            // CompositionToolStripBtn
            // 
            this.CompositionToolStripBtn.CheckOnClick = true;
            this.CompositionToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CompositionToolStripBtn.Image = global::UmlDiagramHW3.Properties.Resources.Composition;
            this.CompositionToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CompositionToolStripBtn.Name = "CompositionToolStripBtn";
            this.CompositionToolStripBtn.Size = new System.Drawing.Size(77, 79);
            this.CompositionToolStripBtn.Text = "Composition";
            this.CompositionToolStripBtn.Click += new System.EventHandler(this.CompositionToolStripBtn_Click);
            // 
            // DependencyToolStripBtn
            // 
            this.DependencyToolStripBtn.CheckOnClick = true;
            this.DependencyToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DependencyToolStripBtn.Image = global::UmlDiagramHW3.Properties.Resources.Dependency;
            this.DependencyToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DependencyToolStripBtn.Name = "DependencyToolStripBtn";
            this.DependencyToolStripBtn.Size = new System.Drawing.Size(77, 79);
            this.DependencyToolStripBtn.Text = "Dependency";
            this.DependencyToolStripBtn.Click += new System.EventHandler(this.DependencyToolStripBtn_Click);
            // 
            // BinaryToolStripBtn
            // 
            this.BinaryToolStripBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BinaryToolStripBtn.CheckOnClick = true;
            this.BinaryToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BinaryToolStripBtn.Image = global::UmlDiagramHW3.Properties.Resources.Binary;
            this.BinaryToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BinaryToolStripBtn.Name = "BinaryToolStripBtn";
            this.BinaryToolStripBtn.Size = new System.Drawing.Size(77, 79);
            this.BinaryToolStripBtn.Text = "Binary Association";
            this.BinaryToolStripBtn.Click += new System.EventHandler(this.BinaryToolStripBtn_Click);
            // 
            // UMLMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.DiagramPanel);
            this.Controls.Add(this.ComponentsToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "UMLMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UML Diagramming";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ComponentsToolStrip.ResumeLayout(false);
            this.ComponentsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewDiagramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadDiagramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDiagramMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem QuitAppMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuItem;
        private System.Windows.Forms.ToolStrip ComponentsToolStrip;
        private System.Windows.Forms.ToolStripButton ClassToolStripBtn;
        private System.Windows.Forms.ToolStripButton GenSpecToolStripBtn;
        private System.Windows.Forms.ToolStripButton AggregationToolStripBtn;
        private System.Windows.Forms.ToolStripButton CompositionToolStripBtn;
        private System.Windows.Forms.ToolStripButton DependencyToolStripBtn;
        private System.Windows.Forms.ToolStripButton BinaryToolStripBtn;
        private System.Windows.Forms.Panel DiagramPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SelectorToolStripBtn;
    }
}

