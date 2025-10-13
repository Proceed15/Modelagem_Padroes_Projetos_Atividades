// --- O CLIENTE ---
// Responsável por montar a corrente e disparar a requisição.
public class CalculadoraDeDescontos
{
    public double Calcula(Orcamento orcamento)
    {
        // 1. Instancia todos os elos da corrente.
        IDesconto d1 = new DescontoPorValorAlto();
        IDesconto d2 = new DescontoPorValorMedio();
        IDesconto d3 = new SemDesconto();

        // 2. Monta a corrente, ligando um elo ao próximo.
        // A ordem aqui é fundamental para a lógica de negócio.
        d1.Proximo = d2;
        d2.Proximo = d3;

        // 3. Inicia o processo chamando o primeiro elo.
        // O cliente não precisa saber qual elo vai de fato resolver a requisição.
        // Ele apenas "joga" a requisição no início da esteira.
        return d1.Desconta(orcamento);
    }
}