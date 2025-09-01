public class Titulo : IElemementoDocumento
{
    public string Texto { get; set; }
    public int Nivel { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}