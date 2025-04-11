using CadastroPessoaEfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoaEfCore.Context;

public class AplicativoDbContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    public string DbPath { get; }

    public AplicativoDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "cadastro_pessoa.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source = {DbPath}");
}
