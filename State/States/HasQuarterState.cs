namespace State.States
{
    public class HasQuarterState : State
    {
        public static HasQuarterState instance = new HasQuarterState();

        private HasQuarterState() { }

        public override void InsertQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n We already have coin inserted. ");
        }

        public override void EjectQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n Returning coin.");
            machine.SetState(machine.getNoQuarterState());
        }

        public override void Dispense(GumballMachineContext machine)
        {
            Console.WriteLine(", No GumBall returnes. ");
        }

        public override void TurnCrank(GumballMachineContext machine)
        {
            Console.WriteLine("\n Giving you gumball");
            machine.SetState(machine.getSoldState());
        }
    }
}
