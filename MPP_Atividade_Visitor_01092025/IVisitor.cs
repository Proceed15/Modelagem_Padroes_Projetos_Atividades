public interface IVisitor
{
    void Visit(Titulo t);
    void Visit(Paragrafo p);
    void Visit(Imagem i);
    void Visit(Tabela tbl);
}