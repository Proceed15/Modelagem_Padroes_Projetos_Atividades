public class Tv : IDevice
    {
        private bool isOn = false;
        private int volume = 0;
 
        public void TogglePower()
        {
            isOn = !isOn;
            Console.WriteLine($"TV power: {isOn}");
        }
 
        public void VolumeUp()
        {
            if (isOn)
            {
                volume++;
                Console.WriteLine($"TV volume: {volume}");
            }
        }
 
        public void VolumeDown()
        {
            if (isOn)
            {
                volume--;
                Console.WriteLine($"TV volume: {volume}");
            }
        }
    }