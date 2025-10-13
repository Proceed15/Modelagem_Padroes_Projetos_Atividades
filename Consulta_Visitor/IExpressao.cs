// --- INTERFACE ELEMENT ---
// Define o contrato para todos os elementos que podem ser "visitados".
// O método Aceita é o ponto de entrada para qualquer Visitor.
public interface IExpressao
{
    void Aceita(IVisitor visitor);
}


