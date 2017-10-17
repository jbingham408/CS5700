using System.Threading;
using RaceData;
using System.Collections.Generic;

namespace RaceDataProcessor
{
    public class Controller
    {
        private SimulatedDataSource data;
        public List<Athlete> myAthletes { get; set; } = null;
        public AthleteObserver controlObserver { get; set; }
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

            while((handler as DataProcessor).athletes == null) { Thread.Sleep(1000); }
            myAthletes = (handler as DataProcessor).athletes;
            while((handler as DataProcessor).observer == null) { Thread.Sleep(1000); }
            controlObserver = (handler as DataProcessor).observer;

            Thread.Sleep(180000);

            data.Stop();
            runningSimulation = false;
        }
    }
}
