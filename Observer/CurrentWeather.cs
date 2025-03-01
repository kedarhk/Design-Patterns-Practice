namespace Observer
{
    public class CurrentWeather : IObserver
    {
        ISubject subject;
        public CurrentWeather(ISubject subject)
        {
            this.subject = subject;
        }

        public void update()
        {
            Console.WriteLine("\n From Current Weather Class - temperature = " + subject.temperature + " pressure = " + subject.pressure);
        }
    }
}