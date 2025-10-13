// Interface Observer: define o que um observador deve ser capaz de fazer.
// Neste caso, ele deve ser capaz de "executar uma ação" ao receber uma nota fiscal.
public interface IAcaoAposGerarNota
{
    void Executa(NotaFiscal nf);
}