public class Leite : BebidaDecorator
{
    public Leite(IBebida bebida) : base(bebida)
    {
    }

    public override string GetDescricao()
    {
        return $"{base.GetDescricao()}, Leite";
    }

    public override double GetCusto()
    {
        return base.GetCusto() + 0.50;
    }
}