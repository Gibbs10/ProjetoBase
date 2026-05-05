using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoBase.Data;
using ProjetoBase.Models;

namespace ProjetoBase.Pages;

public class AdminModel : PageModel
{
    private readonly ProdutoRepository _repositorio;

    public List<Produto> Produtos { get; set; }= new();

    public AdminModel(ProdutoRepository repositorio)
    {
        _repositorio = repositorio;
    }
    public  void OnGet()
    {
        Produtos = _repositorio.GetProdutos();
    }
      // 🔴 DELETE
    public IActionResult OnPostDelete(int id)
    {
        _repositorio.Delete(id);
        return RedirectToPage();
    }
}

