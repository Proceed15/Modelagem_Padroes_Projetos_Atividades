public class ICMS : IImposto
{
    public double CalcularImposto(double valor)
    {
        return valor * 0.18;
    }
}
