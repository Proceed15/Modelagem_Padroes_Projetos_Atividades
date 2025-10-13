// --- INTERFACE VISITOR ---
// Define o contrato para os "visitantes".
// É crucial que exista um método 'Visita' para CADA tipo concreto de Elemento.
// Isso permite que o Visitor saiba exatamente com qual tipo de objeto está lidando,
// sem precisar de `if (obj is Soma)` ou casts.
public interface IVisitor
{
    void VisitaSoma(Soma soma);
    void VisitaSubtracao(Subtracao subtracao);
    void VisitaNumero(Numero numero);
}


