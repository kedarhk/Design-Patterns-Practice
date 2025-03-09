namespace TemplateMethod
{
    public class CoffeeBeverage : CaffineBeverageAbstract
    {
        public override void Brew()
        {
            Console.WriteLine("\n Coffee is Brewing");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("\n Ading sugar and milk");
        }

        public override bool shouldAddCondimentHook()
        {
            Console.WriteLine("\n Do you want condiments in your coffee - ");
            String input = Console.ReadLine();

            if(input.ToLower().StartsWith("y"))
            {
                return true;
            }

            return false;
        }
    }
}
