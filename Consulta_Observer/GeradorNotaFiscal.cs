using System.Collections.Generic;

// Classe Subject (ou Observable): é o objeto que será observado.
public class GeradorDeNotaFiscal
{
    // Mantém uma lista de todos os interessados (observadores).
    private readonly List<IAcaoAposGerarNota> _acoes = new List<IAcaoAposGerarNota>();

    // Permite que novos observadores se registrem.
    public void AdicionaAcao(IAcaoAposGerarNota acao)
    {
        _acoes.Add(acao);
    }

    // O método que, ao ser executado, dispara o evento e notifica todos.
    public void Gera(NotaFiscal nf)
    {
        Console.WriteLine("Gerando nota fiscal...");

        // Notifica cada observador registrado, passando os dados relevantes.
        foreach (var acao in _acoes)
        {
            acao.Executa(nf);
        }
    }
}



