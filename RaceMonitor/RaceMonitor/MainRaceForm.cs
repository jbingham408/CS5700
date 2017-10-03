using System.Threading;
using System.Windows.Forms;
using RaceDataProcessor;

namespace RaceMonitor
{
    public partial class MainRaceForm : Form
    {
        private Controller controller { get; set; }
        private Thread dataThread { get; set; }
        public MainRaceForm()
        {
            InitializeComponent();
            controller = new Controller();
            //controller.Run("../../../SimulationData/Short Race Simulation-01.csv");
            dataThread = new Thread(new ParameterizedThreadStart(controller.Run));
            dataThread.Start("../../../SimulationData/Short Race Simulation-01.csv");
        }

        private void MainRaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataThread.Abort();
            dataThread.Join();
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
