using Command.Vendors;

namespace Command
{
    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.LightOff();
        }

        public void Undo()
        {
            light.LightOn();
        }
    }
}
