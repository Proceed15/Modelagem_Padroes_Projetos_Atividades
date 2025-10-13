public class NotaFiscal
{
    public string RazaoSocial { get; private set; }
    public double ValorBruto { get; private set; }

    public NotaFiscal(string razaoSocial, double valorBruto)
    {
        RazaoSocial = razaoSocial;
        ValorBruto = valorBruto;
    }
}


