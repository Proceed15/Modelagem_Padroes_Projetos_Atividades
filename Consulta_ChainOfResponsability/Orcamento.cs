// Objeto que carrega a informação (a requisição) que passará pela corrente.
public class Orcamento
{
    public double Valor { get; private set; }
    public Orcamento(double valor) { Valor = valor; }
}