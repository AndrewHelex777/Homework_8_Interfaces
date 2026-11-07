namespace Homework_8_Interfaces
{
    interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }
    class TV : IRemoteControl
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("TV is off.");
        }
        public void SetChannel(int c)
        {
            Console.WriteLine($"TV channel set to {c}.");
        }
    }
    class Radio : IRemoteControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Radio is on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Radio is off.");
        }
        public void SetChannel(int c)
        {
            Console.WriteLine($"Radio channel set to {c}.");
        }
    }
    internal class Task4
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Radio radio = new Radio();

            tv.TurnOn();
            tv.TurnOff();
            tv.SetChannel(4);

            radio.TurnOn();
            radio.TurnOff();
            radio.SetChannel(6);
        }
    }
}
