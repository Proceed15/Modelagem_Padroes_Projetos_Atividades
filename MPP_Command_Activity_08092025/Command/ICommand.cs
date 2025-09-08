// ----------------- INTERFACE COMMAND -----------------
public interface ICommand
{
    bool Run();       // executa ação
    bool Desfazer();
}
