public class UsuarioC : Usuario
{
    public UsuarioC(string nome) : base(nome) { }

    public override void ReceberEmail(string mensagem)
    {
        Console.WriteLine($"[UsuarioC] {Nome} recebeu um e-mail: {mensagem}");
    }
}