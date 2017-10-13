using System;
using RaceData;
using RaceData.Messages;
using System.Collections.Generic;

namespace RaceDataProcessor
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        private AthleteObserver observer = new AthleteObserver();
        private List<Athlete> athletes = new List<Athlete>();
        private object myLock = new object();
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
                        time = update.Timestamp,
                        myStatus = "1"
                    };
                    newAthlete.Subscribe(observer);
                    observer.Update(newAthlete);
                    athletes.Add(newAthlete);
                }
            }
            else
            {
                lock(myLock)
                {
                    //RegistrationUpdate update = updateMessage as RegistrationUpdate;
                    Athlete updateAthlete = athletes.Find(a => a.bibNum == updateMessage.BibNumber);
                    updateAthlete.time = updateMessage.Timestamp;
                    if (updateMessage.GetType() == typeof(DidNotStartUpdate))
                        updateAthlete.myStatus = "2";
                    else if (updateMessage.GetType() == typeof(StartedUpdate))
                        updateAthlete.myStatus = "3";
                    else if (updateMessage.GetType() == typeof(LocationUpdate))
                    {
                        updateAthlete.myStatus = "4";
                        updateAthlete.distance = (updateMessage as LocationUpdate).LocationOnCourse;
                    }
                    else if (updateMessage.GetType() == typeof(DidNotFinishUpdate))
                        updateAthlete.myStatus = "5";
                    else if (updateMessage.GetType() == typeof(FinishedUpdate))
                    {
                        updateAthlete.myStatus = "6";
                        updateAthlete.time = (updateMessage as FinishedUpdate).OfficialEndTime;
                    }
                    observer.Update(updateAthlete);                  
                }
            }
            
        }

        public AthleteObserver GetObserver() { return observer; }
    }
}
