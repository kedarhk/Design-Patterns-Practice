namespace Decorator
{
    public abstract class CondimentDecorator : BeverageAbstract
    {
        public  BeverageAbstract beverage;
        public abstract override String getDescription(); // made it abstract as dont want default behaviour of beverage
    }
}