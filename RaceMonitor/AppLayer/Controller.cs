using System.Threading;
using RaceData;

namespace RaceDataProcessor
{
    public class Controller
    {
        private SimulatedDataSource data;
        public bool readData { get; set; }

        public void Run(object inputFile)
        {
            readData = true;
            IAthleteUpdateHandler handler = new DataProcessor();
            data = new SimulatedDataSource()
            {
                InputFilename = inputFile.ToString(),
                Handler = handler
            };

            data.Start();

            while (readData)
            {
                Thread.Sleep(10000);
            }

            data.Stop();
        }
    }
}
