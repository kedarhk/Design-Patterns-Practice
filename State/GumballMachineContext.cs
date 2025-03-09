using StateAb = State.States.State;
using State.States;

namespace State
{
    public class GumballMachineContext
    {
        public static StateAb NoQuarterState;
        public static StateAb HasQuarterState;
        public static StateAb SoldOutState;
        public static StateAb SoldState;

        StateAb currentState;
        public int count = 0;

        public GumballMachineContext(int count)
        {
            NoQuarterState = State.States.NoQuarterState.instance;
            HasQuarterState = State.States.HasQuarterState.instance;
            SoldOutState = State.States.SoldOutState.instance;
            SoldState = State.States.SoldState.instance;

            if (count > 0)
            {
                this.count = count;
                currentState = NoQuarterState;
            }
            else
            {
                currentState = SoldState;
            }
        }

        public void InsertQuarter()
        {
            currentState.InsertQuarter(this);
        }

        public void EjectQuarter()
        {
            currentState.EjectQuarter(this);
        }

        public void TurnCrank()
        {
            currentState.TurnCrank(this);
            currentState.Dispense(this);
        }

        public void ReleaseBall()
        {
            this.count = this.count > 0 ? this.count - 1 : this.count;
            Console.WriteLine("\n ***** Releasing candy ***** , Remaining - " + this.count);
        }

        public void SetState(StateAb st)
        {
            this.currentState = st;
        }

        // dont require getter as static var
        public StateAb getNoQuarterState()
        {
            return NoQuarterState;
        }

        public StateAb getHasQuarterState()
        {
            return HasQuarterState;
        }

        public StateAb getSoldOutState()
        {
            return SoldOutState;
        }

        public StateAb getSoldState()
        {
            return SoldState;
        }
    }
}
