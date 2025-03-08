namespace Decorator
{
    public abstract class BeverageAbstract
    {
        protected String description = "Unknown beverage";

        public virtual String getDescription()
        {
            return this.description;
        }

        public abstract int getCost();
    }
}