namespace Observer
{
    public class Program
    {
        public static void Main(String[] args)
        {
            ISubject weatherData = new WeatherData();

            IObserver currentWeather = new CurrentWeather(weatherData);
            IObserver windSpeed = new WindSpeed(weatherData);

            weatherData.addObserver(currentWeather);
            weatherData.addObserver(windSpeed);

            weatherData.setMeasurements(17,15,90);
            Console.WriteLine("\n");
            weatherData.setMeasurements(190,412,124);
            Console.WriteLine("\n");
            weatherData.removeObserver(currentWeather);
            weatherData.setMeasurements(190346,415242,1524624);
        }
    }
}
