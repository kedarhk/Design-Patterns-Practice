namespace TemplateMethod
{
    public class Program
    {
        public static void Main(String[] args)
        {
            CoffeeBeverage coffee = new CoffeeBeverage();
            TeaBeverage tea = new TeaBeverage();

            Console.WriteLine(
                "\n Preparing tea & coffee has similar steps, some steps are diff, but general algorithm is same"
            );
            tea.PrepareBeverage();
            Console.WriteLine("\n -----");
            coffee.PrepareBeverage();
        }
    }
}
