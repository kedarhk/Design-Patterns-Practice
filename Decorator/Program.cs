namespace Decorator
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Only Beverage
            BeverageAbstract bv = new Beverage1();
            Console.WriteLine("\n Description bv - " + bv.getDescription());
            Console.WriteLine("Cost bv - " + bv.getCost());

            // Only Condiments
            BeverageAbstract cd = new Mocha();
            Console.WriteLine("\n Description cd - " + cd.getDescription());
            Console.WriteLine("Cost cd - " + cd.getCost());

            // Decorator Composition
            BeverageAbstract bv1WithMocha = new Mocha(bv);
            Console.WriteLine("\n Description bv1WithMocha - " + bv1WithMocha.getDescription());
            Console.WriteLine("Cost bv1WithMocha - " + bv1WithMocha.getCost());

            BeverageAbstract bv2WithSoy = new Soy(new Beverage2());
            Console.WriteLine("\n Description bv2WithSoy - " + bv2WithSoy.getDescription());
            Console.WriteLine("Cost bv2WithSoy - " + bv2WithSoy.getCost());
        }
    }
}
