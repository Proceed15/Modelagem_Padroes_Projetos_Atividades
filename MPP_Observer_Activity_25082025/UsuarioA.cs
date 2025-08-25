public class UsuarioA : Usuario
{
    public UsuarioA(string nome) : base(nome) { }

    public override void ReceberEmail(string mensagem)
    {
        Console.WriteLine($"[UsuarioA] {Nome} recebeu um e-mail: {mensagem}");
    }
}