using RaceDataProcessor;

namespace RaceMonitor
{
    public abstract partial class AthleteObserverDecorator : AthleteObserver
    {
        protected AthleteObserver decorateObserver { get; set; }
        protected AthleteObserverDecorator(AthleteObserver obs)
        {
            this.decorateObserver = obs;
        }

        public abstract void Decorate();
        
    }
}
