namespace Decorator
{
    public class Beverage2 : BeverageAbstract
    {
        
        public Beverage2()
        {
            this.description = "Beverage 2";
        }

        public override int getCost()
        {
            return 100;
        }
    }
}