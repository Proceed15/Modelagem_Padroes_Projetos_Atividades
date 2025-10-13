// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Program
{
    public static void Main(string[] args)
    {
        var expressoes = new List<IExpressao>
        {
            new Soma(5, 3),
            new Subtracao(10, 4),
            new Multiplicacao(2, 6),
            new Divisao(20, 5)
        };
        Console.WriteLine("Resultados das Operações:");
        var visitor = new ImpressoraVisitor();
        foreach (var expressao in expressoes)
        {
            expressao.Aceitar(visitor);
            Console.WriteLine($" = {expressao.NumeroEsquerda + expressao.NumeroDireita}");
        }
    }
}