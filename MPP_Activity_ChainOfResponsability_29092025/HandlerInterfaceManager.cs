// O Handler, uma Classe base abstrata que implementa outras Interfaces 
public abstract class HandlerInterfaceManager : IApprover
{
    private IApprover? _next;

    public void SetNext(IApprover next)
    {
        _next = next;
    }

    public virtual void Approve(PurchaseRequest request)
    {
        // Se não conseguir aprovar, passa adiante
        _next?.Approve(request);
    }
}

