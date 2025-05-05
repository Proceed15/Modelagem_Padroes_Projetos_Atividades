//Versão Nova
using System;

class Program
{
    static void Main()
    {
        Director director = new Director();
        CarBuilder builder = new CarBuilder();

        director.ConstructSedanCar(builder);
        Vehicle sedan = builder.GetVehicle();
        Console.WriteLine(sedan);

        director.ConstructTruck(builder);
        Vehicle truck = builder.GetVehicle();
        Console.WriteLine(truck);

        director.ConstructSUV(builder);
        Vehicle suv = builder.GetVehicle();
        Console.WriteLine(suv);
    }
}
