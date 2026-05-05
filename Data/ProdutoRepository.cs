using ProjetoBase.Models;

namespace ProjetoBase.Data;
public class ProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Produto> GetProdutos()
    {
        return _context.Produtos.ToList();
    }
    public void Add(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();
    }
}