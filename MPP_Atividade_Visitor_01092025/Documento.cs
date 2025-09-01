using System.Collections.Generic;

public class Documento
{
    private List<IElemementoDocumento> _elementos = new List<IElemementoDocumento>();

    public void Adicionar(IElemementoDocumento elemento)
    {
        _elementos.Add(elemento);
    }

    public void Processar(IVisitor visitor)
    {
        foreach (var elemento in _elementos)
        {
            elemento.Accept(visitor);
        }
    }
}