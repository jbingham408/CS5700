using System.Threading;
using RaceData;

namespace RaceDataProcessor
{
    public class Controller
    {
        private SimulatedDataSource data;
        public AthleteObserver observer { get; set; } = null;
        public RaceCourse courseInfo = new RaceCourse();
        public RaceEvent eventInfo = new RaceEvent();
        public bool runningSimulation { get; set; }

        public void Run(object inputFile)
        {
            runningSimulation = true;
            IAthleteUpdateHandler handler = new DataProcessor();
            data = new SimulatedDataSource()
            {
                InputFilename = inputFile.ToString(),
                Handler = handler
            };

            data.Start();

            observer = (handler as DataProcessor).GetObserver();
            Thread.Sleep(180000);

            data.Stop();
            runningSimulation = false;
        }
    }
}
