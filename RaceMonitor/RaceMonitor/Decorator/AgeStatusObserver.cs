using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This class is not working
// It was suppose to add a new column in the listview in the AthleteStatusObserver

namespace RaceMonitor.Decorator
{
    public partial class AgeStatusObserver : StatusObserverDecorator
    {
        public AgeStatusObserver(AthleteStatusObserver sObs) : base(sObs)
        {
            Decorate();
        }

        //This adds the new column to the listview
        public void Decorate()
        {
            base.InitializeComponent();

        }
    }
}
