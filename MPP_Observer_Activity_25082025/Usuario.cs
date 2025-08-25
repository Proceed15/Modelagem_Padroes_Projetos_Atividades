public abstract class Usuario : IObserver
{
    protected string Nome;

    public Usuario(string nome)
    {
        Nome = nome;
    }

    public abstract void ReceberEmail(string mensagem);
}