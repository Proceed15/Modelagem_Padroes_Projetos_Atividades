// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        IBebida bebida = new Cafe();

        Console.WriteLine("Central de Bebidas\n");
        Console.WriteLine($"{bebida.GetDescricao()} - R${bebida.GetCusto():F2}");

        bebida = new Leite(bebida);
        Console.WriteLine($"Adicionando Leite");
        Console.WriteLine($"{bebida.GetDescricao()} - R${bebida.GetCusto():F2}");

        bebida = new Acucar(bebida);
        Console.WriteLine($"Adicionando Açúcar");
        Console.WriteLine($"{bebida.GetDescricao()} - R${bebida.GetCusto():F2}");

        bebida = new Chocolate(bebida);
        Console.WriteLine($"Adicionando Chocolate");
        Console.WriteLine($"{bebida.GetDescricao()} - R${bebida.GetCusto():F2}");

        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}