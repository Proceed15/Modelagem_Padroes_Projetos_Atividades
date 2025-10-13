public class DescontoPorValorAlto : CalculadoraDeDescontos
{
    public override void AprovaDesconto(SolicitaDesconto solicita)
    {
        if (solicita.Valor >= 5000)
        {
            Console.WriteLine($"Desconto por valor alto aprovado: R${solicita.Valor * 0.10:F2}");
        }
        else
        {
            base.AprovaDesconto(solicita);
        }
    }
} 