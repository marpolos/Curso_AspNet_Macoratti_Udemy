using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

public class AppDBContext : DBContext
{
    public AppDBContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DBSet<Categoria>? Categorias {get; set; }
    public DBSet<Produto>? Produtos {get; set; }
}