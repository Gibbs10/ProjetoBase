using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoBase.Data;
using ProjetoBase.Models;

public class CadastroModel (ProdutoRepository repositorio) : PageModel
{
    public IActionResult OnGet()
    {
        return Page();
    }
        
    public IActionResult OnPost(string produtoNome, string fabricante, decimal preco, string descricao, int estoque, string img)
    {
        var produto = new Produto
        {
            Id = new Random().Next(1000, 9999),
            ProdutoNome = produtoNome,
            Fabricante = fabricante,
            Preco = preco,
            Descricao = descricao,
            Estoque = estoque,
            Img = img
        };

        repositorio.Add(produto);

        return RedirectToPage("/Index");
    }
}