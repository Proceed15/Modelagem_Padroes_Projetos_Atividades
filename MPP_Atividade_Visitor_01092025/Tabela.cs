public class Tabela : IElemementoDocumento
{
    public List<List<string>> Dados { get; set; } = new List<List<string>>();

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}