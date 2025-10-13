using System.Collections.Generic;

// Classe Invoker: armazena e executa os comandos.
// Ela desacopla quem solicita a ação de quem a executa.
public class FilaDeTrabalho
{
    private List<IComando> _comandos = new List<IComando>();

    public void Adiciona(IComando comando)
    {
        _comandos.Add(comando);
    }

    public void Processa()
    {
        foreach (var comando in _comandos)
        {
            comando.Executa();
        }
    }
}