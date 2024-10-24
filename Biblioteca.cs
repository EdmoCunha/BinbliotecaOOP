public class Biblioteca
{
    public List<Livro> Livros { get; private set; } = new List<Livro>();
    public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();

    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' cadastrado com sucesso.");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado com sucesso.");
    }

    public void EmprestarLivro(string codigoLivro, string numeroUsuario)
    {
        Livro livro = Livros.Find(l => l.Codigo == codigoLivro);
        Usuario usuario = Usuarios.Find(u => u.NumeroIdentificacao == numeroUsuario);

        if (livro != null && usuario != null)
        {
            livro.Emprestar(usuario);
        }
        else
        {
            Console.WriteLine("Livro ou usuário não encontrado.");
        }
    }

    public void DevolverLivro(string codigoLivro)
    {
        Livro livro = Livros.Find(l => l.Codigo == codigoLivro);

        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    public void ListarLivros()
    {
        Console.WriteLine("Livros cadastrados:");
        foreach (var livro in Livros)
        {
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, Quantidade: {livro.QuantidadeEmEstoque}");
        }
    }

    public void ListarUsuarios()
    {
        Console.WriteLine("Usuários cadastrados:");
        foreach (var usuario in Usuarios)
        {
            Console.WriteLine($"Nome: {usuario.Nome}, ID: {usuario.NumeroIdentificacao}");
        }
    }
}
