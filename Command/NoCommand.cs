namespace Command
{
    // Null Object
    public class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }
}
