// --- ESTADO CONCRETO 2: Negativo ---
// Implementa o comportamento da conta quando seu saldo é negativo.
public class Negativo : IEstadoDeUmaConta
{
    public void Deposita(Conta conta, double valor)
    {
        // Regra de negócio: contas com saldo negativo pagam uma taxa de 5% no depósito.
        conta.Saldo += valor * 0.95;
        Console.WriteLine($"Depósito de {valor:C} (- taxa) realizado. Saldo atual: {conta.Saldo:C}");

        // Ponto chave: Verifica se a conta saiu do estado negativo.
        if (conta.Saldo >= 0)
        {
            // O contexto (conta) deve mudar para o estado Positivo.
            conta.Estado = new Positivo();
        }
    }

    public void Saca(Conta conta, double valor)
    {
        // Regra de negócio: não é permitido sacar de uma conta com saldo negativo.
        throw new InvalidOperationException("Não é possível sacar de uma conta com saldo negativo.");
    }
}
