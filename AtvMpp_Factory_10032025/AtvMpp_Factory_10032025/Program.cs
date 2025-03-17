// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public interface IVehicle
{
    void StartRoute();
    void GetCargo();
}
class Carro:IVehicle
{
    public void StartRoute()
    {
        Console.WriteLine("Carro Iniciado!");
    }
    public void GetCargo()
    {
        Console.WriteLine("Carro Transportando!");
    }
}
class Moto:IVehicle
{
    public void StartRoute()
    {
        Console.WriteLine("Moto Ligada!");
    }
    public void GetCargo()
    {
        Console.WriteLine("Moto Transportando!");
    }
}
class Bicicleta:IVehicle
{
    public void StartRoute()
    {
        Console.WriteLine("Bicicleta Pilotada!");
    }
    public void GetCargo()
    {
        Console.WriteLine("Bicicleta Transportando!");
    }
}
public abstract class Transport
{
    public void StartTransport()
    {
        IVehicle vehicle = CreateTransport();
        vehicle.StartRoute();
    }

    public abstract IVehicle CreateTransport();
    /*protected*/
}
public class CarroCreator:Transport
{
    public override IVehicle CreateTransport()
    {
        return new Carro();
    }
}
public class MotoCreator:Transport
{
    public override IVehicle CreateTransport()
    {
        return new Moto();
    }
}
public class BicicletaCreator:Transport
{
    public override IVehicle CreateTransport()
    {
        return new Bicicleta();
    }
}

public class Piloto
{
    private readonly IVehicle _Veiculo;
    private readonly IVehicle _VeiculoAct;

    public Piloto(Transport creator)
    {
        _Veiculo = creator.CreateTransport();
        _VeiculoAct = creator.CreateTransport();
    }

    public void ActionizerTransport()
    {
        _Veiculo.StartRoute();
    }
    public void ActionizerCargo()
    {
        _VeiculoAct.GetCargo();
    }
}
class Program
{
    static void Main(String[] args)
    {
        Transport CarroCreator = new CarroCreator();
        Piloto PilotoCarro = new Piloto (CarroCreator);
        PilotoCarro.ActionizerTransport();
        PilotoCarro.ActionizerCargo();

        Transport MotoCreator = new MotoCreator();
        Piloto PilotoMoto = new Piloto (MotoCreator);
        PilotoMoto.ActionizerTransport();
        PilotoMoto.ActionizerCargo();

        Transport BicicletaCreator = new BicicletaCreator();
        Piloto PilotoBic = new Piloto (BicicletaCreator);
        PilotoBic.ActionizerTransport();
        PilotoBic.ActionizerCargo();
    }
}