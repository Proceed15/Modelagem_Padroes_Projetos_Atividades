public class RelatorioTXT : Relatorio
{
    public RelatorioTXT(Material material) : base(material) { }

    public override string GerarRelatorio()
    {
        return $"Relatório TXT:\n{Material}";
    }
}