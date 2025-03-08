namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        public Soy(BeverageAbstract bv)
        {
            this.beverage = bv;
        }

        public override String getDescription()
        {
            if (beverage != null)
            {
                return beverage.getDescription() + " , Soy ";
            }
            return " Soy ";
        }

        public override int getCost()
        {
            if (beverage != null)
            {
                return beverage.getCost() + 20;
            }
            return 20;
        }
    }
}
