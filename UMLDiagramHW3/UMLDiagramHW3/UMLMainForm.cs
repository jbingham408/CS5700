using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmlDiagramHW3
{
    public partial class UMLMainForm : Form
    {
        public UMLMainForm()
        {
            InitializeComponent();
        }

        private void ClassToolStripBtn_Click(object sender, EventArgs e)
        {
            ClassToolStripBtn.Checked = true;
            GenSpecToolStripBtn.Checked = false;
            AggregationToolStripBtn.Checked = false;
            CompositionToolStripBtn.Checked = false;
            BinaryToolStripBtn.Checked = false;
            DependencyToolStripBtn.Checked = false;
        }

        private void GenSpecToolStripBtn_Click(object sender, EventArgs e)
        {
            ClassToolStripBtn.Checked = false;
            GenSpecToolStripBtn.Checked = true;
            AggregationToolStripBtn.Checked = false;
            CompositionToolStripBtn.Checked = false;
            BinaryToolStripBtn.Checked = false;
            DependencyToolStripBtn.Checked = false;
        }

        private void AggregationToolStripBtn_Click(object sender, EventArgs e)
        {
            ClassToolStripBtn.Checked = false;
            GenSpecToolStripBtn.Checked = false;
            AggregationToolStripBtn.Checked = true;
            CompositionToolStripBtn.Checked = false;
            BinaryToolStripBtn.Checked = false;
            DependencyToolStripBtn.Checked = false;
        }

        private void CompositionToolStripBtn_Click(object sender, EventArgs e)
        {
            ClassToolStripBtn.Checked = false;
            GenSpecToolStripBtn.Checked = false;
            AggregationToolStripBtn.Checked = false;
            CompositionToolStripBtn.Checked = true;
            BinaryToolStripBtn.Checked = false;
            DependencyToolStripBtn.Checked = false;
        }

        private void DependencyToolStripBtn_Click(object sender, EventArgs e)
        {
            ClassToolStripBtn.Checked = false;
            GenSpecToolStripBtn.Checked = false;
            AggregationToolStripBtn.Checked = false;
            CompositionToolStripBtn.Checked = false;
            BinaryToolStripBtn.Checked = false;
            DependencyToolStripBtn.Checked = true;
        }

        private void BinaryToolStripBtn_Click(object sender, EventArgs e)
        {
            ClassToolStripBtn.Checked = false;
            GenSpecToolStripBtn.Checked = false;
            AggregationToolStripBtn.Checked = false;
            CompositionToolStripBtn.Checked = false;
            BinaryToolStripBtn.Checked = true;
            DependencyToolStripBtn.Checked = false;
        }
    }
}
