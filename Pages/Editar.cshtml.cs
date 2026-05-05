using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoBase.Data;
using ProjetoBase.Models;

public class EditarModel : PageModel
{
    private readonly ProdutoRepository _repositorio;

    [BindProperty]
    public Produto Produto { get; set; } = new();

    public EditarModel(ProdutoRepository repositorio)
    {
        _repositorio = repositorio;
    }

    // CARREGA DADOS
    public IActionResult OnGet(int id)
    {
        var produto = _repositorio.GetById(id);

        if (produto == null)
            return RedirectToPage("/Admin");

        Produto = produto;
        return Page();
    }

    // SALVA ALTERAÇÕES
    public IActionResult OnPost()
    {
        _repositorio.Update(Produto);
        return RedirectToPage("/Admin");
    }
}