namespace State.States
{
    public abstract class State
    {
        public abstract void InsertQuarter(GumballMachineContext gm);

        public abstract void EjectQuarter(GumballMachineContext gm);

        public abstract void Dispense(GumballMachineContext gm);

        public abstract void TurnCrank(GumballMachineContext gm);
    }
}
