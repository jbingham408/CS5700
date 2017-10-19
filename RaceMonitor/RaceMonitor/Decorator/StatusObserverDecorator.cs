using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceMonitor.Decorator
{
    public partial class StatusObserverDecorator : AthleteStatusObserver
    {
        protected AthleteStatusObserver baseStatusObserver { get; set; }
        protected StatusObserverDecorator(AthleteStatusObserver sObs)
        {
            this.baseStatusObserver = sObs;
            InitializeComponent();
        }
    }
}
