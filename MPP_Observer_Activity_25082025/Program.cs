using System;
//Console.WriteLine("Hello World"); 
class Program
{
    static void Main(string[] args)
    {
        ISujeito controladorEmail = new ControladorEmail();

        var usuarioA = new UsuarioA("José");
        var usuarioB = new UsuarioB("Linda");
        var usuarioC = new UsuarioC("João");

        controladorEmail.Registrar(usuarioA);
        controladorEmail.Registrar(usuarioB);
        controladorEmail.Registrar(usuarioC);

        Console.WriteLine("Enviando e-mail aos usuários cadastrados");
        controladorEmail.EnviarEmail();

        controladorEmail.Remover(usuarioC);

        Console.WriteLine("\nEnviando e-mail novamente aos usuários cadastrados");
        controladorEmail.EnviarEmail();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}