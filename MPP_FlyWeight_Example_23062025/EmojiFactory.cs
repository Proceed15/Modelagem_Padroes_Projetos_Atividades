class EmojiFactory
{
    private Dictionary<string, EmojiType> _tipos = new Dictionary<string, EmojiType>();

    public EmojiType GetEmojiType(string nome, string cor, string estilo)
    {
        string chave = $"{nome}-{cor}-{estilo}";
        if (!_tipos.ContainsKey(chave))
        {
            _tipos[chave] = new EmojiType(nome, cor, estilo);
        }
        return _tipos[chave];
    }
}