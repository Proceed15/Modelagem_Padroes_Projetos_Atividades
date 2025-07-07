class EmojiType
{
    public string Nome { get; }
    public string Cor { get; }
    public string Estilo { get; }

    public EmojiType(string nome, string cor, string estilo)
    {
        Nome = nome;
        Cor = cor;
        Estilo = estilo;
    }
}