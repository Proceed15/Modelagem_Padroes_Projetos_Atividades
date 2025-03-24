// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program{
    static void Main(string[] args){
        Director director = new Director();
        VehicleBuilder builder = new VehicleBuilder();

        director.SedanCarBuilder(builder);
        Vehicle sedan = builder.GetVehicle();
        Console.WriteLine(sedan);

        director.TruckBuilder(builder);
        Vehicle truck = builder.GetVehicle();
        Console.WriteLine(truck);

        director.SUVBuilder(builder);
        Vehicle suv = builder.GetVehicle();
        Console.WriteLine(suv);
    }
}
