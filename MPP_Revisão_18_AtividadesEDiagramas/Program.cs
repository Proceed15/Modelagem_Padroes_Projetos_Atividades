// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main(string[] args)
    {
        var metadadoComum = new Metadado(
            capa: "capa_comum.jpg",
            edicao: "Primeira Edição",
            autores: new string[] { "João Silva", "Maria Santos" }
        );

        var livro1 = new Livro(
            titulo: "Dom Quixote",
            autor: "Miguel de Cervantes",
            metadados: metadadoComum,
            editora: "Editora Universal",
            anoPublicacao: 1990
        );

        var artigo1 = new Artigo(
            titulo: "Estudos sobre Dom Quixote",
            autor: "Carlos de Oliveira",
            metadados: metadadoComum,
            revista: "Revista Literária",
            dataPublicacao: new DateTime(2023, 1, 15)
        );

        var colecao = new Colecao(
            titulo: "Coleção sobre Dom Quixote",
            autor: "Vários Autores",
            metadados: metadadoComum
        );
        colecao.Adicionar(livro1);
        colecao.Adicionar(artigo1);

        var biblioteca = new BibliotecaDigital();
        biblioteca.CadastrarMateria(livro1);
        biblioteca.CadastrarMateria(artigo1);
        biblioteca.CadastrarMateria(colecao);
        Console.WriteLine("Digite o Nome do Livro ou Artigo: ");
        string NomeLivroArtigo = Console.ReadLine();
        
        var materialEncontrado = biblioteca.BuscarMateria(NomeLivroArtigo);
        if (materialEncontrado != null)
        {
            Console.WriteLine($"Material encontrado: {materialEncontrado}");
        }
        Console.WriteLine(biblioteca.GerarRelatorio(materialEncontrado, "pdf"));
        Console.WriteLine(biblioteca.GerarRelatorio(materialEncontrado, "html"));
        Console.WriteLine(biblioteca.GerarRelatorio(materialEncontrado, "txt"));
        biblioteca.EmprestarMateria(materialEncontrado);
        biblioteca.DevolverMateria(materialEncontrado);
        Console.WriteLine("\n\n\n\n\n\n\n\n\n");
        Console.WriteLine("Digite o Nome do Autor: ");
        string NomeAutor = Console.ReadLine();
        var AutorEncontrado = biblioteca.BuscarAutor(NomeAutor);
        if (AutorEncontrado != null)
        {
            Console.WriteLine($"Autor encontrado: {AutorEncontrado}");
        }
        Console.WriteLine(biblioteca.GerarRelatorio(AutorEncontrado, "pdf"));
        Console.WriteLine(biblioteca.GerarRelatorio(AutorEncontrado, "html"));
        Console.WriteLine(biblioteca.GerarRelatorio(AutorEncontrado, "txt"));
        biblioteca.EmprestarMateria(AutorEncontrado);
        biblioteca.DevolverMateria(AutorEncontrado);
        
    }
}

