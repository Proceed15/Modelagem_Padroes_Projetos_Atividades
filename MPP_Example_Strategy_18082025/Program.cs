// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
//Todas as Explicações Estão em seus Próprios Arquivos

// 4. O Cliente (Client)
// Cria um objeto de Estratégia Concreta e o passa para o Contexto.
public class Program
{
    public static void Main(string[] args)
    {
        // O cliente cria o objeto de Contexto.
        var context = new Context();

        Console.WriteLine("Calculadora com Padrão Strategy");
        Console.WriteLine("--------------------------------");

        Console.Write("Digite o primeiro número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Escolha a operação (+, -, *, %): ");
        string action = Console.ReadLine();

        // O cliente decide qual estratégia usar com base na entrada do usuário.
        switch (action)
        {
            case "+":
                context.SetStrategy(new ConcreteStrategyAdd());
                break;
            case "-":
                context.SetStrategy(new ConcreteStrategySubtract());
                break;
            case "*":
                context.SetStrategy(new ConcreteStrategyMultiply());
                break;
            case "%":
                context.SetStrategy(new ConcretestrategyDivision());
                break;    
            default:
                Console.WriteLine("Operação inválida.");
                return;
        }

        // O cliente pede para o contexto executar a estratégia definida.
        int result = context.ExecuteStrategy(a, b);

        Console.WriteLine($"\nResultado: {result}");
    }
}
