public class Artigo : Material
{
    public string Revista { get; set; }
    public DateTime DataPublicacao { get; set; }

    public Artigo(string titulo, string autor, Metadado metadados, string revista, DateTime dataPublicacao)
        : base(titulo, autor, metadados)
    {
        Revista = revista;
        DataPublicacao = dataPublicacao;
    }

    public override string ToString()
    {
        return base.ToString() + $", Revista: {Revista}, Data de Publicação: {DataPublicacao.ToShortDateString()}";
    }
}