public class DisplayJanela : IObservador
{
    public string Nome { get; }
    public DisplayJanela(string nome) => Nome = nome;

    public void Atualizar(float temperatura)
    {
        Console.WriteLine($"{Nome} Mostra: Temperatura Atual {temperatura}°C");
    }
}