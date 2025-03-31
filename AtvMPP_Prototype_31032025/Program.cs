using System.Runtime;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Net;

class Program{
    static void Main()
    {
        Soldier soldier123 = new()
        {
            Name = "Special Weapons Dalek",
            Weapon = "Pulse Cannon",
            Accessory = new Accessory("Vortex Manipulator")
        };

        Soldier Soldier1 = soldier123.DeepCopy();
        Soldier Soldier2 = soldier123.DeepCopy();
        Soldier Soldier3 = soldier123.ShallowCopy();
        Soldier Soldier4 = soldier123.ShallowCopy();

        Console.WriteLine("Soldier Info");
        Console.WriteLine(" Soldier 1: ");
        ShowSoldier(Soldier1);
        Console.WriteLine(" Soldier 2: ");
        ShowSoldier(Soldier2);
        Console.WriteLine(" Soldier 3: ");
        ShowSoldier(Soldier3);
        Console.WriteLine(" Soldier 4: ");
        ShowSoldier(Soldier4);
    }
        public static void ShowSoldier(Soldier Soldier)
        {
            Console.WriteLine($" Name: {Soldier.Name:s}\n Weapon: {Soldier.Weapon:d}");
            Console.WriteLine($" Accessory: {Soldier.Accessory.Name:d}");
        }
}