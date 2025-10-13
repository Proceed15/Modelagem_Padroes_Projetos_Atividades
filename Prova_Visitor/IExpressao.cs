public interface IExpressao : IVisitor
{
    public double NumeroEsquerda { get; set; }
    public double NumeroDireita { get; set; }
    void Visitar(Soma soma);
    void Visitar(Multiplicacao multiplicacao);
    void Visitar(Subtracao subtracao);
    void Visitar(Divisao divisao);
    void Aceitar(IVisitor visitor);
}
