namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        public Mocha() { }

        public Mocha(BeverageAbstract beverage)
        {
            this.beverage = beverage;
        }

        public override String getDescription()
        {
            if (beverage != null)
            {
                return beverage.getDescription() + " , Mocha ";
            }
            return " Mocha ";
        }

        public override int getCost()
        {
            if (beverage != null)
            {
                return beverage.getCost() + 10;
            }
            return 10;
        }
    }
}
