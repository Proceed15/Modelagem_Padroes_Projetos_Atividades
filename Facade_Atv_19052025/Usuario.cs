public class Usuario
{
    private string nome;
    public long matricula;
    private double saldo;

    public Usuario()
    {
    }

    public Usuario(string nome, long matricula, double saldo)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.saldo = saldo;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public long Matricula
    {
        get { return matricula; }
        set { matricula = value; }
    }

    public double Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }
}