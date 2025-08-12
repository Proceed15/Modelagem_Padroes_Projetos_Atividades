public class Colecao : Material
{
    private List<Material> _materiais = new List<Material>();

    public Colecao(string titulo, string autor, Metadado metadados)
        : base(titulo, autor, metadados)
    {
    }

    public void Adicionar(Material material)
    {
        _materiais.Add(material);
    }

    public void Remover(Material material)
    {
        _materiais.Remove(material);
    }

    public IEnumerable<Material> ObterMateriais()
    {
        var random = new Random();
        return _materiais.OrderBy(m => random.Next());
    }

    public override string ToString()
    {
        var itens = string.Join("\n", ObterMateriais().Select(m => m.ToString()));
        return base.ToString() + "\nItens na Coleção:\n" + itens;
    }
}