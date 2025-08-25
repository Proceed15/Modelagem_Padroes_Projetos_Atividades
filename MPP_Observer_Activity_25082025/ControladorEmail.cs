using System;
using System.Collections.Generic;

public class ControladorEmail : ISujeito
{
    private List<IObserver> _observadores = new List<IObserver>();

    public void Registrar(IObserver observer)
    {
        if (!_observadores.Contains(observer))
            _observadores.Add(observer);
    }

    public void Remover(IObserver observer)
    {
        _observadores.Remove(observer);
    }

    public void EnviarEmail()
    {
        foreach (var observer in _observadores)
        {
            observer.ReceberEmail("Nova promoção disponível! Confira agora.");
        }
    }
}