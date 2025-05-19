// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        FachadaBanco fachada = new FachadaBanco();

        Usuario usuario1 = new Usuario("João", 123456, 1000.00);

        fachada.addUsuario(usuario1);

        fachada.deposito(123456, 500.00);
        fachada.saque(123456, 200.00);

        fachada.saque(999999, 100.00);

        Usuario usuario2 = new Usuario("Maria", 789012, 1500.00);
        fachada.addUsuario(usuario2);
        fachada.deposito(789012, 300.00);
        Console.WriteLine("Valor inválido para saque.");
        Console.WriteLine("Saldo insuficiente para realizar o saque.");
    }
}