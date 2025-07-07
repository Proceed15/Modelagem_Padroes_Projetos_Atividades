public class Particle
{
    private readonly double _positionX;
    private readonly double _positionY;
    private readonly double _velocityX;
    private readonly double _velocityY;
    private readonly IParticleType _type;

    public Particle(IParticleType type, double positionX, double positionY, double velocityX, double velocityY)
    {
        _type = type;
        _positionX = positionX;
        _positionY = positionY;
        _velocityX = velocityX;
        _velocityY = velocityY;
    }

    public void Draw()
    {
        _type.Draw(_positionX, _positionY);
    }
}