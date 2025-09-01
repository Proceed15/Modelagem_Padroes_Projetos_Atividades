public class Imagem : IElemementoDocumento
{
    public string Path { get; set; }
    public string Caption { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}