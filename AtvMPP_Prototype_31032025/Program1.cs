// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Versão Antiga

/* public interface Prototype
{
    public void DisplayInfo();
    public Prototype clone();
}

class Soldier : Prototype
{
    public string Name;
    public string Weapon;
    public Soldier(string Name, string Weapon){
        this.Name = Name;
        this.Weapon = Weapon;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Soldier Info");
        Console.WriteLine($"Name: {this.Name} " + $"\nWeapon: {this.Weapon}");
    }

    public Prototype clone(){
        return new Soldier(this.Name, this.Weapon);
    }
}

class secondaryProgram{
    public Prototype getSoldier(){
        return new Soldier("Special Weapons Dalek", "Pulse Cannon");
    }
}
class Program1{
    static void Main()
    {
        secondaryProgram secProg = new secondaryProgram();

        Prototype soldier1 = secProg.getSoldier();
        soldier1.DisplayInfo();

        Prototype soldier2 = secProg.getSoldier();
        soldier2.DisplayInfo();

        Prototype soldier3 = secProg.getSoldier();
        soldier3.DisplayInfo();
    }
} */