public class RelatorioPDF : Relatorio
{
    public RelatorioPDF(Material material) : base(material) { }

    public override string GerarRelatorio()
    {
        return $"Relatório PDF:\n{Material}";
    }
}