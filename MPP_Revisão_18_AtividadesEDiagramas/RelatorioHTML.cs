public class RelatorioHTML : Relatorio
{
    public RelatorioHTML(Material material) : base(material) { }

    public override string GerarRelatorio()
    {
        return $"<html><head><h1>Relatório HTML:</h1></head><body><p>{Material}</p></body></html>";
    }
}