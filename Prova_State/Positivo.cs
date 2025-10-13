public class Positivo : IEstadoDeUmaConta
{
    public void Negativada(Conta conta)
    {
        Console.WriteLine("Conta mudou para o estado: Negativo");
        conta.MudarEstado(new Negativo());
    }
    public void Positivada(Conta conta)
    {
        Console.WriteLine("AVISO: Conta já está no estado Positivo.");
    }
}