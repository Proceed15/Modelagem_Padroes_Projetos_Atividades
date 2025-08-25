public class UsuarioB : Usuario
{
    public UsuarioB(string nome) : base(nome) { }

    public override void ReceberEmail(string mensagem)
    {
        Console.WriteLine($"[UsuarioB] {Nome} recebeu um e-mail: {mensagem}");
    }
}