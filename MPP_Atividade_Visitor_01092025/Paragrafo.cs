public class Paragrafo : IElemementoDocumento
{
    public string Texto { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}