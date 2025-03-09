namespace Command.Vendors
{
    public class Light
    {
        private String room;
        public Light(String room)
        {
            this.room = room;
        }
        public void LightOn()
        {
            Console.WriteLine(room + " Light is on \n");
        }

        public void LightOff()
        {
            Console.WriteLine(room + " Light is off \n");
        }
    }
}