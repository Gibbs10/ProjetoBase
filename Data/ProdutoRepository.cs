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
     // 🔴 MÉTODO DE DELETE
    public void Delete(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

        if (produto != null)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }

    public Produto? GetById(int id)
{
    return _context.Produtos.FirstOrDefault(p => p.Id == id);
}

public void Update(Produto produto)
{
    _context.Produtos.Update(produto);
    _context.SaveChanges();
}
}
