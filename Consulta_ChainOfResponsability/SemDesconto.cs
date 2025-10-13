// --- HANDLER FINAL (OU NULL HANDLER) ---
// Este é o último elo. Ele não tem um "próximo".
// Ele representa o caso final, onde nenhuma regra anterior se aplicou.
public class SemDesconto : IDesconto
{
    // Não precisa de um próximo, pois é o fim da linha.
    public IDesconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento)
    {
        Console.WriteLine("Nenhum desconto aplicável.");
        return 0; // Encerra a corrente retornando 0.
    }
}