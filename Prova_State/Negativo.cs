public class Negativo : IEstadoDeUmaConta
{
    public void Positivada(Conta conta)
    {
        Console.WriteLine("Conta mudou para o estado: Positivo");
        conta.MudarEstado(new Positivo());
    }
    public void Negativada(Conta conta)
    {
        Console.WriteLine("AVISO: Conta já está no estado Negativo.");
    }
}