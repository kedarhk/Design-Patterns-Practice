namespace Decorator
{
    public class Beverage1 : BeverageAbstract
    {
        
        public Beverage1()
        {
            this.description = "Beverage 1";
        }

        public override int getCost()
        {
            return 89;
        }
    }
}