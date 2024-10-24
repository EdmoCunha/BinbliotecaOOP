public class Usuario
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}\nID: {NumeroIdentificacao}\nEndereço: {Endereco}\nContato: {Contato}");
    }
}