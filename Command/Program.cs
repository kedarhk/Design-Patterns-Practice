using Command.Vendors;

namespace Command
{
    public class Program
    {
        // Client
        public static void Main(String[] args)
        {
            // Create Concrete Vendors
            Light lvroom = new Light("Living Room");
            Light kroom = new Light("Kitchen");
            Light broom = new Light("Bath Room");

            // Package receivers/request in commands
            LightOnCommand lvroomOn = new LightOnCommand(lvroom);
            LightOffCommand lvroomOff = new LightOffCommand(lvroom);

            LightOnCommand kroomOn = new LightOnCommand(kroom);
            LightOffCommand kroomOff = new LightOffCommand(kroom);

            LightOnCommand broomOn = new LightOnCommand(broom);
            LightOffCommand broomOff = new LightOffCommand(broom);

            // Create Invoker
            RemoteControl rm = new RemoteControl();
            rm.setCommand(0, lvroomOn, lvroomOff);
            rm.setCommand(1, kroomOn, kroomOff);
            rm.setCommand(2, broomOn, broomOff);

            // Visualizing Invoker commands
            Console.WriteLine(rm);
            Console.WriteLine("\n \n");

            // Calling request, which is decoupled with Command object, we dont no how to turn lightsOn or its method
            rm.OnButtonPressed(0); // lv room on
            rm.OnButtonPressed(1); // k room on
            rm.Undo(); // k room off
            rm.OffButtonPressed(0); // lv room off
            rm.Undo(); // lv room on
            rm.Undo(); // lv room off
            rm.Undo(); // no more operations
            rm.OnButtonPressed(2); // b room on
            rm.OnButtonPressed(0); // lv room on
            rm.OnButtonPressed(01); // k room on
            rm.Undo(); // k room off
            rm.OffButtonPressed(0); // lv room off  
            rm.Undo(); // lv room On
            rm.Undo(); // lv room Off
            rm.Undo(); // b room off
            rm.Undo(); // no more op
        }
    }
}
