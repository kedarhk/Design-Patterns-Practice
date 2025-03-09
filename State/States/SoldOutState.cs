namespace State.States
{
    public class SoldOutState : State
    {
        public static SoldOutState instance = new SoldOutState();

        private SoldOutState() { }

        public override void InsertQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n SOLD OUT GumBalls are sold out.");
        }

        public override void EjectQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n SOLD OUT No coin to eject ");
        }

        public override void Dispense(GumballMachineContext machine)
        {
            Console.WriteLine(", No gumball to dispense");
        }

        public override void TurnCrank(GumballMachineContext machine)
        {
            Console.WriteLine("\n SOLD OUT Gumballs are not there");
        }
    }
}
