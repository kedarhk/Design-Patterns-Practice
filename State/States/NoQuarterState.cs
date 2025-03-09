namespace State.States
{
    public class NoQuarterState : State
    {
        public static NoQuarterState instance = new NoQuarterState();

        private NoQuarterState() { }

        public override void InsertQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n Inserted Coin is accepted.");
            machine.SetState(machine.getHasQuarterState());
        }

        public override void EjectQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n No Coin to eject. ");
        }

        public override void Dispense(GumballMachineContext machine)
        {
            Console.WriteLine(", Cannot return gumball no coin is inserted.");
        }

        public override void TurnCrank(GumballMachineContext machine)
        {
            Console.WriteLine("\n No point of cranking, no coin is inserted. ");
        }
    }
}
