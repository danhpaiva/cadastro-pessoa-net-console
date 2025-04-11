namespace CadastroPessoaEfCore.Models;

public class Pessoa
{
    public int PessoaId { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Sexo { get; set; }
    public string Celular { get; set; }
    public bool ClienteAtivo { get; set; }
}
