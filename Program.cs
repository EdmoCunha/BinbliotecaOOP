class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        
        Livro livro1 = new Livro { Titulo = "O Senhor do C#", Autor = "Lucas Fogaça", ISBN = "123456", Genero = "Aventura", QuantidadeEmEstoque = 5, Codigo = "001" };
        Livro livro2 = new Livro { Titulo = "11 homens e um segredo", Autor = "Fogaça", ISBN = "654321", Genero = "Ficção", QuantidadeEmEstoque = 3, Codigo = "002" };
        biblioteca.CadastrarLivro(livro1);
        biblioteca.CadastrarLivro(livro2);

        
        Usuario usuario1 = new Usuario { Nome = "Édmo Cunha Pithan ", NumeroIdentificacao = "U001", Endereco = "Rua A, 123", Contato = "joao@example.com" };
        Usuario usuario2 = new Usuario { Nome = "Mia Kalifa", NumeroIdentificacao = "U002", Endereco = "Rua B, 456", Contato = "maria@example.com" };
        biblioteca.CadastrarUsuario(usuario1);
        biblioteca.CadastrarUsuario(usuario2);

        
        biblioteca.ListarLivros();
        biblioteca.ListarUsuarios();

        
        biblioteca.EmprestarLivro("001", "U001");
        biblioteca.DevolverLivro("001");
    }
}