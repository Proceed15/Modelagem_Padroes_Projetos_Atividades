public class EstacaoMeteorologica
{
    private List<IObservador> displays = new List<IObservador>(); 
    private float temp;

    public void SetTemperatura(float temp)
    {
        this.temp = temp; // Atualiza as Temperaturas em Ambos os Displays 
        NotificarObservadores();
    }

    public void AdicionarObservador(IObservador obs) => displays.Add(obs);
    public void RemoverObservador(IObservador obs) => displays.Remove(obs);

    public void NotificarObservadores()
    {
        foreach (var p in displays)
            p.Atualizar(temp);
    }
}