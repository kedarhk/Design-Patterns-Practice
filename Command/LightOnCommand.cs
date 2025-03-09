using Command.Vendors;

namespace Command
{
    public class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.LightOn();
        }

        public void Undo()
        {
            light.LightOff();
        }
    }
}
