namespace State
{
    public class Program
    {
        public static void Main(String[] args)
        {
            GumballMachineContext gm = new GumballMachineContext(2);

            // Coin inserted and returned as it is
            gm.InsertQuarter();
            gm.EjectQuarter();

            // Coin inserted gumball given, remaining 1 shown
            gm.InsertQuarter();
            gm.TurnCrank();

            // Tells no coin inserted
            gm.TurnCrank();

            // Tells no coin to eject
            gm.EjectQuarter();

            // Coin inserted gumball given, remaining 0 shown
            gm.InsertQuarter();
            gm.TurnCrank();

            // Tells Sold out
            gm.EjectQuarter();
            gm.TurnCrank();
        }
    }
}
