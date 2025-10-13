// --- ELEMENTO CONCRETO 1: Numero ---
public class Numero : IExpressao
{
    public int Valor { get; private set; }
    public Numero(int valor) { Valor = valor; }

    // Implementação do "Double Dispatch" - Parte 1
    // O Numero, ao ser visitado, chama o método específico para ele no visitor.
    // Ele diz ao visitor: "Olá, eu sou um Numero. Me visite como um Numero."
    public void Aceita(IVisitor visitor)
    {
        visitor.VisitaNumero(this);
    }
}