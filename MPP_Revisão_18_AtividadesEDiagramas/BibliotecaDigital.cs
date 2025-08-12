public class BibliotecaDigital
{
    private List<Material> _materiais = new List<Material>();

    public void CadastrarMateria(Material material)
    {
        _materiais.Add(material);
    }

    public Material BuscarMateria(string titulo)
    {
        return _materiais.FirstOrDefault(m => m.Titulo == titulo);
    }

    public Material BuscarAutor(string autor)
    {
        return _materiais.FirstOrDefault(m => m.Autor == autor);
    }

    public void EmprestarMateria(Material material)
    {
        Console.WriteLine($"Emprestando: {material}");
    }

    public void DevolverMateria(Material material)
    {
        Console.WriteLine($"Devolvendo: {material}");
    }

    public void ExibirMateriais()
    {
        var random = new Random();
        var listaEmbaralhada = _materiais.OrderBy(m => random.Next());

        foreach (var material in listaEmbaralhada)
        {
            Console.WriteLine(material);
        }
    }

    public string GerarRelatorio(Material material, string formato)
    {
        Relatorio relatorio = null;

        switch (formato.ToLower())
        {
            case "pdf":
                relatorio = new RelatorioPDF(material);
                break;
            case "html":
                relatorio = new RelatorioHTML(material);
                break;
            case "txt":
                relatorio = new RelatorioTXT(material);
                break;
            default:
                throw new ArgumentException("Formato de relatório inválido.");
        }

        return relatorio.GerarRelatorio();
    }
}