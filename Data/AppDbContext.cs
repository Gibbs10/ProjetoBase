using Microsoft.EntityFrameworkCore;
using ProjetoBase.Models;

namespace ProjetoBase.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Produto> Produtos { get; set; }
}