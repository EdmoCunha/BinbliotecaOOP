public interface IPesquisavel
{
    List<Livro> PesquisarPorTitulo(string titulo);
    List<Livro> PesquisarPorAutor(string autor);
    List<Livro> PesquisarPorGenero(string genero);
}