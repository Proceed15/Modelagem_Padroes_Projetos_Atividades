public class DescontoPorValorMedio : CalculadoraDeDescontos
{
    public override void AprovaDesconto(SolicitaDesconto solicita)
    {
        if (solicita.Valor >= 1000 && solicita.Valor < 5000)
        {
            Console.WriteLine($"Desconto por valor médio aprovado: R${solicita.Valor * 0.05:F2}");
        }
        else
        {
            base.AprovaDesconto(solicita); 
    }
    }
}