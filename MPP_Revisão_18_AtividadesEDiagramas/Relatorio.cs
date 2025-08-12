public abstract class Relatorio
{
    protected Material Material { get; set; }

    public Relatorio(Material material)
    {
        Material = material;
    }

    public abstract string GerarRelatorio();
}