namespace Observer
{
    public interface ISubject 
    {
        public int temperature {get;}
        public int pressure {get; }
        public int windSpeed {get; }
        public void addObserver(IObserver ob);
        public void removeObserver(IObserver ob);
        public void setMeasurements(int temperature, int pressure, int windSpeed);
    }
}