public class SemDesconto : CalculadoraDeDescontos
{
    public override void AprovaDesconto(SolicitaDesconto solicita)
    {
        Console.WriteLine("Desconto não aprovado.");
    }
}