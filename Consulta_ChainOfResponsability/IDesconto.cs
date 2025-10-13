// --- A INTERFACE HANDLER ---
// Define o contrato para todos os objetos que podem fazer parte da corrente.
public interface IDesconto
{
    // Propriedade para "ligar" um elo ao outro, formando a corrente.
    IDesconto Proximo { get; set; }

    // Método que cada elo usará para tentar processar a requisição.
    double Desconta(Orcamento orcamento);
}