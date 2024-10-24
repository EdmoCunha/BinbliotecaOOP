public class Livro : ItemBiblioteca, IEmprestavel, IPesquisavel
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            Console.WriteLine($"Livro '{Titulo}' emprestado a {usuario.Nome}. Exemplares disponíveis: {QuantidadeEmEstoque}");
        }
        else
        {
            Console.WriteLine("Não há exemplares disponíveis para empréstimo.");
        }
    }

    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"Livro '{Titulo}' devolvido. Exemplares disponíveis: {QuantidadeEmEstoque}");
    }

    public List<Livro> PesquisarPorTitulo(string titulo)
    {
        
        return null;
    }

    public List<Livro> PesquisarPorAutor(string autor)
    {
        
        return null;
    }

    public List<Livro> PesquisarPorGenero(string genero)
    {
        // Implementar lógica de pesquisa
        return null;
    }
}

