using CadastroPessoaEfCore.Context;
using CadastroPessoaEfCore.Models;
using Microsoft.EntityFrameworkCore;
using static System.Console;

using var db = new AplicativoDbContext();

WriteLine($"\nLocal: {db.DbPath}");
WriteLine("Inserindo uma pessoa: ");
db.Add(new Pessoa
{
    Nome = "Daniel Paiva",
    Cpf = "123456",
    Celular = "31988775566",
    Sexo = "M",
    ClienteAtivo = true
});
await db.SaveChangesAsync();

WriteLine("\nLendo uma pessoa...");
var pessoa = await db.Pessoas
    .OrderBy(p => p.PessoaId)
    .FirstAsync();

WriteLine($"\nNome: {pessoa.Nome}");
