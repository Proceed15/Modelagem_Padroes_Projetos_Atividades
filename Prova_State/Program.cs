// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Controle de Estado de Uma Conta");
        Conta conta1 = new Conta();
        conta1.Positivada(); // Muda para Positivo
        conta1.Negativada(); // Muda para Negativo 
        conta1.Positivada(); // Muda para Positivo
    }
}
