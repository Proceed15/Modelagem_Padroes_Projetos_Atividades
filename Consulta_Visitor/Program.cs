// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n--- Padrão Visitor ---");

        // Vamos montar a árvore da expressão: ( (10 + 5) - (2 + 3) )
        // Filho esquerdo: (10 + 5)
        IExpressao esquerda = new Soma(new Numero(10), new Numero(5));

        // Filho direito: (2 + 3)
        IExpressao direita = new Soma(new Numero(2), new Numero(3));

        // Raiz da árvore
        IExpressao conta = new Subtracao(esquerda, direita);

        // 1. Criamos a operação que queremos executar (o Visitor).
        IVisitor impressora = new ImpressoraVisitor();

        Console.Write("Expressão: ");
        // 2. Iniciamos o processo de visitação a partir da raiz da estrutura.
        // O mecanismo de "double dispatch" se encarrega de percorrer a árvore
        // e chamar os métodos corretos no visitor.
        conta.Aceita(impressora); // A mágica acontece aqui!

        // Se quiséssemos adicionar a funcionalidade de "Calcular", criaríamos
        // uma nova classe 'CalculadoraVisitor' sem tocar em NENHUMA das
        // classes de Expressão. Esse é o poder do Visitor.
        Console.WriteLine(); // Nova linha para formatação.
    }
}