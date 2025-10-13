using System;
using System.Collections.Generic;

public class GeradordeNotaFiscal : IAcaoAposGerarNota
{
    private List<IAcaoAposGerarNota> _observadores = new List<IAcaoAposGerarNota>();
    public void RegistrarAcao(IAcaoAposGerarNota acao)
    {
        if (!_observadores.Contains(acao))
            _observadores.Add(acao);
    }
    public void Remover(IAcaoAposGerarNota acao)
    {
        if (_observadores.Contains(acao))
            _observadores.Remove(acao);
    }
    public void EmitirNotaFiscal()
    {
        foreach (var acao in _observadores)
        {
            acao.CriarNotaFiscal("Nota fiscal gerada com Sucesso!");
        }
    }
    public void CriarNotaFiscal(string mensagem)
    {
        Console.WriteLine("Nota Gerada com Sucesso!");
    }
}


