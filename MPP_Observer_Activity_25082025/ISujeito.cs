public interface ISujeito
{
    void Registrar(IObserver observer);
    void Remover(IObserver observer);
    void EnviarEmail();
}