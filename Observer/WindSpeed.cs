namespace Observer
{
    public class WindSpeed : IObserver
    {
        ISubject subject;
        public WindSpeed(ISubject subject)
        {
            this.subject = subject;
        }

        public void update()
        {
            Console.WriteLine("\n From Current WindSpeed Class - windspeed = " + subject.windSpeed);
        }
    }
}