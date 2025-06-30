class Program
{
    static void Main(string[] args)
    {
        Car sedan = new SedanCar();
        sedan.Manufacture();

        Console.WriteLine("\n");

        Car hatch = new HatchCar();
        hatch.Manufacture();
    }
}