using System;
using RaceData;
using RaceData.Messages;

namespace RaceDataProcessor
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
            Console.Write(updateMessage.ToString());
        }
    }
}
