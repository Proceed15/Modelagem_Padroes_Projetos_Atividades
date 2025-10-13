using System;

// --- ESTADO CONCRETO 1: Positivo ---
// Implementa o comportamento da conta quando seu saldo é positivo.
public class Positivo : IEstadoDeUmaConta
{
    public void Deposita(Conta conta, double valor)
    {
        // Regra de negócio: contas com saldo positivo recebem um bônus de 2% no depósito.
        conta.Saldo += valor * 1.02;
        Console.WriteLine($"Depósito de {valor:C} (+ bônus) realizado. Saldo atual: {conta.Saldo:C}");
        // O estado não muda ao depositar em uma conta positiva.
    }

    public void Saca(Conta conta, double valor)
    {
        conta.Saldo -= valor;
        Console.WriteLine($"Saque de {valor:C} realizado. Saldo atual: {conta.Saldo:C}");

        // Ponto chave: Após a ação, o próprio estado verifica se uma transição é necessária.
        if (conta.Saldo < 0)
        {
            // O contexto (conta) deve mudar para o estado Negativo.
            conta.Estado = new Negativo();
        }
    }
}
