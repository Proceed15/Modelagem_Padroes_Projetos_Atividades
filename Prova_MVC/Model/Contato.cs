namespace Prova_MVC.Model
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}";
        }
    }
}
