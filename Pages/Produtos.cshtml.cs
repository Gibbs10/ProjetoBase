using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoBase.Data;
using ProjetoBase.Models;

namespace ProjetoBase.Pages;
public class ProdutosModel : PageModel
{    private readonly ProdutoRepository _repository;

    // public List<Produto> Produtos { get; set; } = new();

    public Produto Produtos { get; set; } 



    public ProdutosModel(ProdutoRepository repository)
    {
    // TODO: atribua o parâmetro repository ao campo _repository
    _repository = repository;    
    }
    public void OnGet()
    {
    // TODO: chame _repository.ObterTodos() e atribua o resultado à propriedade Produtos
    Produtos = _repository.GetProduto();

    }
}
