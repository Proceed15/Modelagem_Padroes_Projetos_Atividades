// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n--- Padrão State ---");

        // Criamos uma conta com saldo inicial positivo. O estado interno será 'Positivo'.
        Conta conta = new Conta(500.0);
        Console.WriteLine($"Estado inicial: {conta.Estado.GetType().Name}, Saldo: {conta.Saldo:C}");

        // A ação é delegada para o objeto 'Positivo', que aplica o bônus.
        conta.Deposita(100.0); // Saldo vai para 602

        // A ação é delegada para o objeto 'Positivo', que permite o saque.
        // O saldo se torna negativo, e o objeto 'Positivo' MUDA o estado da conta para 'Negativo'.
        conta.Saca(800.0); // Saldo vai para -198

        Console.WriteLine($"Estado atual: {conta.Estado.GetType().Name}, Saldo: {conta.Saldo:C}");

        // A ação agora é delegada para o objeto 'Negativo', que aplica a taxa.
        // O saldo se torna positivo, e o objeto 'Negativo' MUDA o estado da conta para 'Positivo'.
        conta.Deposita(1000.0); // Saldo vai para 752

        Console.WriteLine($"Estado final: {conta.Estado.GetType().Name}, Saldo: {conta.Saldo:C}");

        // Tenta sacar com o estado 'Negativo'.
        try
        {
            Conta contaNegativa = new Conta(-100);
            Console.WriteLine($"\nEstado inicial: {contaNegativa.Estado.GetType().Name}, Saldo: {contaNegativa.Saldo:C}");
            contaNegativa.Saca(50);
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERRO ESPERADO: {e.Message}");
        }

        Conta ContaPositiva = new Conta(4435.43);
        Console.WriteLine($"\nEstado inicial: {ContaPositiva.Estado.GetType().Name}, Saldo: {ContaPositiva.Saldo:C}");
        ContaPositiva.Deposita(500);
    }
}
