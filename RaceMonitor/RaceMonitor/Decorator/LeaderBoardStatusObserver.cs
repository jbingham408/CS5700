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
    public partial class LeaderBoardStatusObserver : StatusObserverDecorator
    {
        public LeaderBoardStatusObserver(AthleteStatusObserver sObs) : base(sObs)
        {
            Decorate();
        }

        public override void Decorate()
        {
            
        }
    }
}
