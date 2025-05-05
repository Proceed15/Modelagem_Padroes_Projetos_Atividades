using System.Runtime;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Reflection.Metadata.Ecma335;

class Program{
    static void Main()
    {
        Soldier soldier1234 = new()
        {
            Name = "Special Weapons Dalek",
            Weapon = "Pulse Cannon",
            Accessory = new Accessory("Vortex Manipulator")
        };
        Soldier other = new(){
            Name = "Dalek Sec",
            Weapon = "Proton Cannon",
            Accessory = new Accessory("Vortex Manipulator")
        };

        Soldier Soldier1 = soldier1234.DeepCopy();
        Soldier Soldier2 = soldier1234.DeepCopy();
        Soldier Soldier3 = soldier1234.ShallowCopy();
        Soldier Soldier4 = soldier1234.ShallowCopy();
        Soldier Soldier5 = other.DeepCopy();

        Console.WriteLine("Soldier Info");
        Console.WriteLine(" Soldier 1: ");
        ShowSoldier(Soldier1);
        Console.WriteLine(" Soldier 2: ");
        ShowSoldier(Soldier2);
        Console.WriteLine(" Soldier 3: ");
        ShowSoldier(Soldier3);
        Console.WriteLine(" Soldier 4: ");
        ShowSoldier(Soldier4);
        Console.WriteLine(" Soldier 5 ");
        ShowSoldier(Soldier5);
    }
        public static void ShowSoldier(Soldier Soldier)
        {
            Console.WriteLine($" Name: {Soldier.Name:s}\n Weapon: {Soldier.Weapon:d}");
            Console.WriteLine($" Accessory: {Soldier.Accessory.Name:d}");
        }
}