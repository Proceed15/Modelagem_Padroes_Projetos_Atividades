//Versão Antiga
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
class Vehicle
{
    public int Seats { get; set; }
    public Engine Engine { get; set; }
    public Transmission Transmission { get; set; }
    public VehicleType VehicleType { get; set; }
    public bool Airbag { get; set; } 

    public override string ToString()
    {
        return $"Tipo: {VehicleType}, Assentos: {Seats}, Motor: {Engine.Power}L, " +
               $"Transmissão: {Transmission}, Airbag: {Airbag}";
    }
}
class Engine
{
    public double Power { get; set; }

    public Engine(double power)
    {
        Power = power;
    }
}
enum Transmission
{
    MANUAL,
    AUTOMATIC,
    AUTOMATIC_SEQUENTIAL
}
enum VehicleType
{
    SEDAN,
    SPORTCAR,
    PICKUPTRUCK,
    TRUCK,
    SUV
}
interface IBuilder
{
    void Reset();
    Vehicle GetVehicle();
    void SetSeats(int seats);
    void SetEngine(Engine engine);
    void SetTransmission(Transmission transmission);
    void SetVehicleType(VehicleType vehicleType);
}

class CarBuilder : IBuilder
{
    private Vehicle _vehicle;

    public CarBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _vehicle = new Vehicle();
    }

    public void SetSeats(int seats)
    {
        _vehicle.Seats = seats;
    }

    public void SetEngine(Engine engine)
    {
        _vehicle.Engine = engine;
    }

    public void SetTransmission(Transmission transmission)
    {
        _vehicle.Transmission = transmission;
    }

    public void SetVehicleType(VehicleType vehicleType)
    {
        _vehicle.VehicleType = vehicleType;
    }

    public void SetAirbag(bool airbag)
    {
        _vehicle.Airbag = airbag;
    }

    public Vehicle GetVehicle()
    {
        return _vehicle;
    }
}

class Director
{
    public void ConstructSedanCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetVehicleType(VehicleType.SEDAN);
        builder.SetSeats(5);
        builder.SetEngine(new Engine(1.6));
        builder.SetTransmission(Transmission.AUTOMATIC);
    }

    public void ConstructTruck(IBuilder builder)
    {
        builder.Reset();
        builder.SetVehicleType(VehicleType.TRUCK);
        builder.SetSeats(2);
        builder.SetEngine(new Engine(5.0));
        builder.SetTransmission(Transmission.MANUAL);
    }

    public void ConstructSUV(IBuilder builder)
    {
        builder.Reset();
        builder.SetVehicleType(VehicleType.SUV);
        builder.SetSeats(5);
        builder.SetEngine(new Engine(2.6));
        builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
        (builder as CarBuilder)?.SetAirbag(true);
    }
}
