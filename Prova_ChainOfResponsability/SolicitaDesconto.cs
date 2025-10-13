public class SolicitaDesconto
{
    public double Valor { get; set; }
    public string TipoDesconto { get; set; }
    public SolicitaDesconto(double valor, string tipoDesconto)
    {
        Valor = valor;
        TipoDesconto = tipoDesconto;
    }
}