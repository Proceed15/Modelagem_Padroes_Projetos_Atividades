class Emoji
{
    private int x;
    private int y;
    private EmojiType tipo;

    public Emoji(int x, int y, EmojiType tipo)
    {
        this.x = x;
        this.y = y;
        this.tipo = tipo;
    }

    public void Mostrar()
    {
        Console.WriteLine($"\nMostrando emoji {tipo.Nome} ({tipo.Cor}, {tipo.Estilo}) na posição ({x}, {y})");
    }
}