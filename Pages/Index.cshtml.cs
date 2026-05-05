using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoBase.Data;
using ProjetoBase.Models;

namespace ProjetoBase.Pages;

public class IndexModel : PageModel
{
    private readonly ProdutoRepository _repositorio;

    public List<Produto> Produtos { get; set; }= new();

    public IndexModel(ProdutoRepository repositorio)
    {
        _repositorio = repositorio;
    }
    public  void OnGet()
    {
        Produtos = _repositorio.GetProdutos();
    }
}

