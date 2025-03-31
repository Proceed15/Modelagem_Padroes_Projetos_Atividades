// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public interface Prototype
{
    public void DisplayInfo();
    public Prototype clone();
}

class Person : Prototype
{
    public string name;
    public int age;
    public string hairColor;
    public double height;

    public Person(string name, int age, string hairColor, double height)
    {
        this.name = name;
        this.age = age;
        this.hairColor = hairColor;
        this.height = height;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine("/n----- Informações do Sujeito de Pesquisa -----");
        Console.WriteLine($"Nome: {this.name}" + $"\nIdade: {this.age}" +
        $"\nCor do Cabelo: {this.hairColor}" +
        $"\nAltura: {this.height}m");
    }

    public Prototype clone(){
        return new Person(this.name, this.age, this.hairColor, this.height);
    }
}

class secondaryProgram{
    public Prototype getPerson(){
        return new Person("njgdkxl\a", 19, "Branco", 1.84);
    }
}

class Program{
    static void Main()
    {
    secondaryProgram secProg = new secondaryProgram();

    Prototype person1 = secProg.getPerson();
    person1.DisplayInfo();

    Prototype person2 = secProg.getPerson();
    person2.DisplayInfo();

    Prototype person3 = secProg.getPerson();
    person3.DisplayInfo();
    }
}
