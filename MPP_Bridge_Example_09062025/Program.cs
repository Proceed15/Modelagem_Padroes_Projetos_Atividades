// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
 
namespace MPP_Bridge_Example_09062025
{

 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ligando a TV");
            IDevice tv = new Tv();
            RemoteControl remote = new AdvancedRemoteControl(tv);
            remote.TogglePower();
            remote.VolumeUp();
            ((AdvancedRemoteControl)remote).Mute();
 
            IDevice radio = new Radio();
            remote = new AdvancedRemoteControl(radio);
            remote.TogglePower();
            remote.VolumeUp();
            remote.VolumeDown();
        }
    }
}