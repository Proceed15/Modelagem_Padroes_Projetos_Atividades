public class Acucar : BebidaDecorator
{
    public Acucar(IBebida bebida) : base(bebida)
    {
    }

    public override string GetDescricao()
    {
        return $"{base.GetDescricao()}, Açúcar";
    }

    public override double GetCusto()
    {
        return base.GetCusto() + 0.20;
    }
}