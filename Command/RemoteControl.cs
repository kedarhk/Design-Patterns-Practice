using System.Collections.Generic;

namespace Command
{
    // Invoker
    public class RemoteControl
    {
        private ICommand[] commandsOn;
        private ICommand[] commandsOff;
        Stack<ICommand> undoHistory;

        public RemoteControl()
        {
            commandsOn = new ICommand[7];
            commandsOff = new ICommand[7];
            undoHistory = new Stack<ICommand>();

            for (int i = 0; i < 7; i++)
            {
                commandsOn[i] = new NoCommand();
                commandsOff[i] = new NoCommand();
            }
        }

        public void setCommand(int slot, ICommand commandOn, ICommand commandOff)
        {
            commandsOn[slot] = commandOn;
            commandsOff[slot] = commandOff;
        }

        public override String ToString()
        {
            String res = "";
            for (int i = 0; i < 7; i++)
            {
                res +=
                    "\n slot - "
                    + (i + 1)
                    + " , On - "
                    + commandsOn[i].GetType().Name
                    + " , Off - "
                    + commandsOff[i].GetType().Name;
            }
            return res;
        }

        public void OnButtonPressed(int slot)
        {
            commandsOn[slot].Execute();
            undoHistory.Push(commandsOn[slot]);
        }

        public void OffButtonPressed(int slot)
        {
            commandsOff[slot].Execute();
            undoHistory.Push(commandsOff[slot]);
        }

        public void Undo()
        {
            if (undoHistory.Count < 1)
            {
                Console.WriteLine("** No more operations to undo ** \n");
                return;
            }
            ICommand un = undoHistory.Pop();
            un.Undo();
        }
    }
}
