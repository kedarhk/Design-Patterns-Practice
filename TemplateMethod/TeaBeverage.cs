namespace TemplateMethod
{
    public class TeaBeverage : CaffineBeverageAbstract
    {
        public override void Brew()
        {
            Console.WriteLine("\n Tea is brewing , stepping.");
        }
 
        public override void AddCondiments()
        {
            Console.WriteLine("\n Add Lemon in tea. ");
        }
    }
}
