public class Chocolate : BebidaDecorator
{
    public Chocolate(IBebida bebida) : base(bebida)
    {
    }

    public override string GetDescricao()
    {
        return $"{base.GetDescricao()}, Chocolate";
    }

    public override double GetCusto()
    {
        return base.GetCusto() + 0.75;
    }
}