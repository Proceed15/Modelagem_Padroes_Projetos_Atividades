public class ParticleType : IParticleType
{
    private readonly string _color;
    private readonly string _sprite;
    private readonly int _size;

    public ParticleType(string color, string sprite, int size)
    {
        _color = color;
        _sprite = sprite;
        _size = size;
    }

    public void Draw(double x, double y)
    {
        Console.WriteLine($"Desenhando partícula de cor {_color}, sprite {_sprite}, tamanho {_size} na posição ({x}, {y})");
    }
}