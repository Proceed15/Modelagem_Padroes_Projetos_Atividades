public interface IVisitor
{
    void Visitar(NumeroEsquerda numeroEsquerda);
    void Visitar(NumeroDireita numeroDireita);
    void Visitar(Soma soma);
    void Visitar(Multiplicacao multiplicacao);
    void Visitar(Subtracao subtracao);
    void Visitar(Divisao divisao);
}
