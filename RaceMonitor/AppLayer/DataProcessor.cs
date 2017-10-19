using System;
using RaceData;
using RaceData.Messages;
using System.Collections.Generic;

namespace RaceDataProcessor
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        public List<Athlete> athletes = new List<Athlete>();
        private object myLock = new object();

        //Takes the data and either creates a new subject or updates their information
        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
            if(updateMessage.GetType() == typeof(RegistrationUpdate))
            {
                lock (myLock)
                {
                    RegistrationUpdate update = updateMessage as RegistrationUpdate;
                    Athlete newAthlete = new Athlete()
                    {
                        bibNum = update.BibNumber,
                        firstName = update.FirstName,
                        lastName = update.LastName,
                        gender = update.Gender,
                        age = update.Age,
                        myStatus = "1"
                    };
                    newAthlete.distance.Add(0.0);
                    newAthlete.time.Add(update.Timestamp);
                    athletes.Add(newAthlete);

                }
            }
            else
            {
                lock(myLock)
                {
                    int updateAthleteIndex = athletes.FindIndex(a => a.bibNum == updateMessage.BibNumber);
                    athletes[updateAthleteIndex].time.Add(updateMessage.Timestamp);
                    if (updateMessage.GetType() == typeof(DidNotStartUpdate))
                        athletes[updateAthleteIndex].myStatus = "2";
                    else if (updateMessage.GetType() == typeof(StartedUpdate))
                        athletes[updateAthleteIndex].myStatus = "3";
                    else if (updateMessage.GetType() == typeof(LocationUpdate))
                    {
                        athletes[updateAthleteIndex].myStatus = "4";
                        athletes[updateAthleteIndex].distance.Add((updateMessage as LocationUpdate).LocationOnCourse);
                    }
                    else if (updateMessage.GetType() == typeof(DidNotFinishUpdate))
                        athletes[updateAthleteIndex].myStatus = "5";
                    else if (updateMessage.GetType() == typeof(FinishedUpdate))
                    {
                        athletes[updateAthleteIndex].myStatus = "6";
                        athletes[updateAthleteIndex].time.Add((updateMessage as FinishedUpdate).OfficialEndTime);
                    }

                    athletes[updateAthleteIndex].Notify();
                }
            }
            
        }
    }
}
