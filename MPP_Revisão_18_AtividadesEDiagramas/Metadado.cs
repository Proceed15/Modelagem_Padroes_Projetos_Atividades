public class Metadado
{
    public string Capa { get; set; }
    public string Edicao { get; set; }
    public string[] Autores { get; set; }

    public Metadado(string capa, string edicao, string[] autores)
    {
        Capa = capa;
        Edicao = edicao;
        Autores = autores;
    }

    public override string ToString()
    {
        return $"Capa: {Capa}, Edição: {Edicao}, Autores: {string.Join(", ", Autores)}";
    }
}