public class Livro : Material
{
    public string Editora { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo, string autor, Metadado metadados, string editora, int anoPublicacao)
        : base(titulo, autor, metadados)
    {
        Editora = editora;
        AnoPublicacao = anoPublicacao;
    }

    public override string ToString()
    {
        return base.ToString() + $", Editora: {Editora}, Ano de Publicação: {AnoPublicacao}";
    }
}