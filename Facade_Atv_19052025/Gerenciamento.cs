public class Gerenciamento
{
    public void deposito(Usuario usuario, double valor)
    {
        if (valor > 0)
        {
            usuario.Saldo += valor;
            Console.WriteLine($"\nDepósito de R$ {valor:F2} realizado. Novo saldo: R$ {usuario.Saldo:F2}");
        }
        else
        {
            Console.WriteLine("Valor inválido para depósito.");
        }
    }
    public void saque(Usuario usuario, double valor)
    {
        if (valor > 0 && usuario.Saldo >= valor)
        {
            usuario.Saldo -= valor;
            Console.WriteLine($"\nSaque de R$ {valor:F2} realizado. Novo saldo: R$ {usuario.Saldo:F2}");
        }
        else if (valor <= 0)
        {
            Console.WriteLine("Valor inválido para saque.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    }
}