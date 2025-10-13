public class DisplayCelular : IObservador
{
    public string Nome { get; }
    public DisplayCelular(string nome) => Nome = nome;

    public void Atualizar(float temperatura)
    {
        Console.WriteLine($"{Nome} Mostra: Temperatura Atual {temperatura}°C");
    }
}