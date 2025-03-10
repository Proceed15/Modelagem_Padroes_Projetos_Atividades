using System;

public interface Itransporte
{
    void Transportar(string carga);
}
class Terrestre:Itransporte
{
    public void Transportar(string carga)
    {
        Console.WriteLine($"Transportando '{carga}' por via terrestre");
    }
}
public class Cliente
{
    private readonly Itransporte _transporte;

    public Cliente(TransporteFactoryCreator creator)
    {
        _transporte = creator.CriarTransporte();
    }

    public void RealizarTransporte(string carga)
    {
        _transporte.Transportar(carga);
    }
}
class Marítimo:Itransporte
{
    public void Transportar(string carga)
    {
        Console.WriteLine($"Transportando '{carga}' por via marítima");
    }
}
public abstract class TransporteFactoryCreator
{
    public abstract Itransporte CriarTransporte();
}
public class TerrestreCreator:transporteFactory
{
    public override Itransporte CriarTransporte()
    {
        return new Terrestre();
    }
}
public class MaritimoCreator:transporteFactory
{
    public override Itransporte CriarTransporte()
    {
        return new Marítimo();
    }
}
class Program
{
    static void Main(string[] args)
    {
        /*
        var Terrestre = new Terrestre();
        var Maritimo = new Marítimo();

        Terrestre.Transportar("Cargas Pesadas");
        Maritimo.Transportar("Cargas Leves");
        */
        TransporteFactoryCreator terrestreCreator = new TerrestreCreator();
        Cliente clienteTerrestre = new Cliente (terrestreCreator);
        clienteTerrestre.RealizarTransporte("Cargas Pesadas");

        TransporteFactoryCreator maritimoCreator = new MaritimoCreator();
        Cliente clienteMaritimo = new Cliente (maritimoCreator);
        clienteMaritimo.RealizarTransporte("Cargas Leves");
    }
}