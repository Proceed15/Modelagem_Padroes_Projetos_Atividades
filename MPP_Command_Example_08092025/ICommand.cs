// ----------------- INTERFACE COMMAND -----------------
public interface ICommand
{
    bool Run(); // Retorna true se sucesso
    bool Desfazer();
}
