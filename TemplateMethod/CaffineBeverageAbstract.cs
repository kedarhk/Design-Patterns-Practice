namespace TemplateMethod
{
    public abstract class CaffineBeverageAbstract
    {
        // This is template ( algorithm template )
        public void PrepareBeverage()
        {
            BoilWater();
            Brew(); // steps in algorithm, which will be implemented in subclasses
            PourInCup();
            if (shouldAddCondimentHook()) // this lets subclasses hook functionality ( Addition things ), this is not abstract, can be empty method
            {
                AddCondiments(); // steps in algorithm, which will be implemented in subclasses
            }
        }

        public void BoilWater()
        {
            Console.WriteLine("\n Boiling Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("\n Pouring in cup");
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public virtual bool shouldAddCondimentHook()
        {
            return true;
        }
    }
}
