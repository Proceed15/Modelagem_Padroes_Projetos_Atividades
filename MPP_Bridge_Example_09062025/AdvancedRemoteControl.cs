    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }
 
        public override void TogglePower()
        {
            device.TogglePower();
        }
 
        public override void VolumeUp()
        {
            device.VolumeUp();
        }
 
        public override void VolumeDown()
        {
            device.VolumeDown();
        }
 
        public void Mute()
        {
            Console.WriteLine("Remote: Mute device");
            while (true)
            {
                device.VolumeDown();
                // interrompe o loop quando o volume chegar a zero
                break;
            }
        }
    }
