namespace State.States
{
    public class SoldState : State
    {
        public static SoldState instance = new SoldState();

        private SoldState() { }

        public override void InsertQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n Coin is already inserted.");
        }

        public override void EjectQuarter(GumballMachineContext machine)
        {
            Console.WriteLine("\n Gumball already given.");
        }

        public override void Dispense(GumballMachineContext machine)
        {
            machine.ReleaseBall();
            if (machine.count > 0)
            {
                machine.SetState(machine.getNoQuarterState());
            }
            else
            {
                machine.SetState(machine.getSoldOutState());
            }
        }

        public override void TurnCrank(GumballMachineContext machine)
        {
            Console.WriteLine("\n We are giving you gumball.");
        }
    }
}
