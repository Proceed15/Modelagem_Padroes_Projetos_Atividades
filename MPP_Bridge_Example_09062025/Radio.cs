public class Radio : IDevice
    {
        private bool isOn = false;
        private int volume = 0;
 
        public void TogglePower()
        {
            isOn = !isOn;
            Console.WriteLine($"Radio power: {isOn}");
        }
 
        public void VolumeUp()
        {
            if (isOn)
            {
                volume++;
                Console.WriteLine($"Radio volume: {volume}");
            }
        }
 
        public void VolumeDown()
        {
            if (isOn)
            {
                volume--;
                Console.WriteLine($"Radio volume: {volume}");
            }
        }
    }