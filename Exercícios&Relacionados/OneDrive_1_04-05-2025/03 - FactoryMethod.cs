using System;

// Interface que define o contrato para transporte
public interface ITransporte
{
    void Transportar(string carga); // Método para transportar uma carga
}

// Classe que implementa o transporte terrestre
class Terrestre : ITransporte
{
    public void Transportar(string carga)
    {
        // Implementação do transporte terrestre
        Console.WriteLine($"Transportando '{carga}' por via terrestre.");
    }
}

// Classe que implementa o transporte marítimo
class Maritimo : ITransporte
{
    public void Transportar(string carga)
    {
        // Implementação do transporte marítimo
        Console.WriteLine($"Transportando '{carga}' por via marítima.");
    }
}

// Classe abstrata que serve como uma fábrica de transporte
public abstract class TransporteFactory
{
    public abstract ITransporte CriarTransporte(); // Método abstrato para criar um transporte
}

// Fábrica concreta para criar transporte terrestre
public class TerrestreCreator : TransporteFactory
{
    public override ITransporte CriarTransporte()
    {
        // Retorna uma nova instância de transporte terrestre
        return new Terrestre();
    }
}

// Fábrica concreta para criar transporte marítimo
public class MaritimoCreator : TransporteFactory
{
    public override ITransporte CriarTransporte()
    {
        // Retorna uma nova instância de transporte marítimo
        return new Maritimo();
    }
}

// Classe cliente que utiliza a fábrica de transporte
public class Cliente 
{
    private readonly ITransporte _transporte; // Atributo que armazena o transporte

    // Construtor que recebe uma fábrica de transporte
    public Cliente(TransporteFactory creator)
    {
        // Cria o transporte usando a fábrica fornecida
        _transporte = creator.CriarTransporte();
    } 

    // Método para realizar o transporte de uma carga
    public void RealizarTransporte(string carga)
    {
        _transporte.Transportar(carga); // Chama o método de transporte
    }
}

// Classe principal que contém o método Main
class Program
{
   static void Main(string[] args)
   {
       // Cria uma fábrica para transporte terrestre
       TransporteFactory terrestreCreator = new TerrestreCreator();
       // Cria um cliente que usa a fábrica de transporte terrestre
       Cliente clienteTerrestre = new Cliente(terrestreCreator);
       // Realiza o transporte de uma carga pesada
       clienteTerrestre.RealizarTransporte("Cargas Pesadas"); 

       // Cria uma fábrica para transporte marítimo
       TransporteFactory maritimoCreator = new MaritimoCreator();
       // Cria um cliente que usa a fábrica de transporte marítimo
       Cliente clienteMaritimo = new Cliente(maritimoCreator);
       // Realiza o transporte de uma carga leve
       clienteMaritimo.RealizarTransporte("Cargas leves");
    }
}