public abstract class Material
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public Metadado Metadados { get; set; }

    public Material(string titulo, string autor, Metadado metadados)
    {
        Titulo = titulo;
        Autor = autor;
        Metadados = metadados;
    }

    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, {Metadados}";
    }
}