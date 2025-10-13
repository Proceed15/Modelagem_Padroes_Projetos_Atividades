using System;
using System.Collections.Generic;

public class NotaFiscal
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
}