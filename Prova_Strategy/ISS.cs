public class ISS : IImposto
{
    public double CalcularImposto(double valor)
    {
        return valor * 0.06;
    }
}
