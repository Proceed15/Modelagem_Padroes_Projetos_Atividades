public abstract class RemoteControl
    {
        protected IDevice device;
 
        protected RemoteControl(IDevice device)
        {
            this.device = device;
        }
 
        public abstract void TogglePower();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
    }
