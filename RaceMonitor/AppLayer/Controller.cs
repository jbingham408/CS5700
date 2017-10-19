using System.Threading;
using RaceData;
using System.Collections.Generic;

//This class gets all the information from the Library given to use that reads in the athlete info
//and puts that into a new subject

namespace RaceDataProcessor
{
    public class Controller
    {
        private SimulatedDataSource data;
        public List<Athlete> myAthletes { get; set; } = null;
        public RaceCourse courseInfo = new RaceCourse();
        public RaceEvent eventInfo = new RaceEvent();
        public bool runningSimulation { get; set; }

        //reads in the data
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

            Thread.Sleep(180000);

            data.Stop();
            runningSimulation = false;
        }
    }
}
